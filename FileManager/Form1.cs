namespace FileManager
{
    public partial class Form1 : Form
    {
        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private FileInfo fileToBeCopied = null;
        private bool isFile = false;
        public string currentlySelectedItemName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtFilePath.Text = filePath;
            LoadFilesAndDirectories();
        }

        public void LoadFilesAndDirectories()
        {
            try
            {
                if (!isFile)
                    OpenFolder();
                else
                    OpenFile();
            }
            catch (Exception)
            {

                throw;
            }
        }


        #region listViewFunctions
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            var currentFullPath = filePath + "/" + currentlySelectedItemName;

            FileAttributes fileAttributes = File.GetAttributes(currentFullPath);

            if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
            }
            else
            {
                isFile = true;
            }

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var currentFullPath = filePath + "/" + currentlySelectedItemName;
            TxtFilePath.Text = currentFullPath;

            LoadButtonAction();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = listView1.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }


        #endregion

        #region OpenFunctions
        protected void OpenFolder()
        {
            LblFileName.Text = "--";
            LblFileType.Text = "--";
            DirectoryInfo fileList;
            fileList = new DirectoryInfo(filePath);
            FileInfo[] files = fileList.GetFiles();
            DirectoryInfo[] directories = fileList.GetDirectories();

            listView1.Items.Clear();


            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Extension == ".txt")
                    listView1.Items.Add(files[i].Name, 0);
            }

            for (int i = 0; i < directories.Length; i++)
            {

                listView1.Items.Add(directories[i].Name, 1);
            }

        }

        protected void OpenFile()
        {

            string currentFullPath = filePath + "/" + currentlySelectedItemName;
            FileInfo fileDetails = new FileInfo(currentFullPath);

            LblFileName.Text = fileDetails.Name;
            LblFileType.Text = fileDetails.Extension;

        }



        #endregion

        #region Navigation

        private void BtnGo_Click(object sender, EventArgs e)
        {
            LoadButtonAction();

        }
        public void LoadButtonAction()
        {
            filePath = TxtFilePath.Text;
            LoadFilesAndDirectories();
            isFile = false;
        }

        public void NavigateBack()
        {
            try
            {
                RemoveBackSlash();
                string path = TxtFilePath.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                isFile = false;
                TxtFilePath.Text = path;
                RemoveBackSlash();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void RemoveBackSlash()
        {
            string path = TxtFilePath.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
                TxtFilePath.Text = path.Substring(0, path.Length - 1);
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            NavigateBack();
            LoadButtonAction();
        }


        #endregion

        #region CRUD
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyFile();
        }

        protected void DeleteFile()
        {
            if (listView1.Focused)
            {
                var focusedItem = listView1.FocusedItem;
                var fullItemPath = filePath + "/" + focusedItem.Text;

                var file = new FileInfo(fullItemPath);
                var fileOrFolder = file.Extension != "" ? "file" : "folder";
                var fileAttributes = File.GetAttributes(fullItemPath);
                var isThisDirectory = (fileAttributes & FileAttributes.Directory) == FileAttributes.Directory;

                DialogResult confirmation = MessageBox.Show($"Are you sure you want to delete this  {fileOrFolder}", "Confirmation", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes & isThisDirectory)
                    Directory.Delete(fullItemPath);
                else if (confirmation == DialogResult.Yes & !isThisDirectory)
                {
                    file.Delete();
                }

                isFile = false;
                LoadButtonAction();

            }
        }


        protected void CopyFile()
        {
            if (listView1.Focused)
            {
                var focusedItem = listView1.FocusedItem;
                var fullItemPath = filePath + "/" + focusedItem.Text;

                fileToBeCopied = new FileInfo(fullItemPath);
            }
        }

        #endregion

        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            string fileName = "";
            bool isThisAfile = false;
            string messageBoxInformation = "What's the name of the file?";
            string isThisAfileInformation = "is this a .txt file";
            var messageBoxResult = ShowInputDialogBox(ref fileName, ref isThisAfile, messageBoxInformation, "Information", 300, 200, isThisAfileInformation);

            if(messageBoxResult.HasFlag(DialogResult.OK))
            {
                CreateFile(isThisAfile, fileName);
            }
        }



        private static DialogResult ShowInputDialogBox(ref string input,ref bool checkboxValue, string prompt, string title = "Title", int width = 300, int height = 200, string checkboxText = "info")
        {
            Size size = new Size(width, height);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = title;

            //Create a new label to hold the prompt
            Label label = new Label
            {
                Text = prompt,
                Location = new Point(5, 5),
                Width = size.Width - 10
            };
            inputBox.Controls.Add(label);

            //Create a textbox to accept the user's input
            TextBox textBox = new TextBox
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, label.Location.Y + 25),
                Text = input
            };
            inputBox.Controls.Add(textBox);


            //Create a checkbox to accept the user's input
            CheckBox checkbox = new CheckBox
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, label.Location.Y + 60),
                Text = checkboxText,
                Checked = checkboxValue
            };
            inputBox.Controls.Add(checkbox);

            //Create an OK Button 
            Button okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = "&OK",
                Location = new Point(size.Width - 80 - 80, size.Height - 30)
            };
            inputBox.Controls.Add(okButton);

            //Create a Cancel Button
            Button cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new Size(75, 23),
                Text = "&Cancel",
                Location = new Point(size.Width - 80, size.Height - 30)
            };
            inputBox.Controls.Add(cancelButton);

            //Set the input box's buttons to the created OK and Cancel Buttons respectively so the window appropriately behaves with the button clicks
            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            //Show the window dialog box 
            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;


            checkboxValue = checkbox.Checked;
            //After input has been submitted, return the input value
            return result;
        }

        protected void CreateFile(bool isThisAFile, string nameOfFile)
        {
            nameOfFile = !isThisAFile ? nameOfFile :  $"{nameOfFile}.txt";
            var newFileOrDirectoryPath = $"{filePath}/{nameOfFile}";


            if (!isThisAFile)
            {
                if (!Directory.Exists(newFileOrDirectoryPath))
                {
                    Directory.CreateDirectory(newFileOrDirectoryPath);
                }
             } 
            else
            {
                if (!Directory.Exists(newFileOrDirectoryPath))
                {
                    var newFile =File.Create(newFileOrDirectoryPath);
                    newFile.Close();
                }
            }

            LoadButtonAction();
        }
    }

}