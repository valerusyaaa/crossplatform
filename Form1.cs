using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_Saklakova
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    struct ClassInfo
    {
        [MarshalAs(UnmanagedType.U1)]
        public bool isBaseClass;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string author;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string name;
        [MarshalAs(UnmanagedType.I4)]
        public int pages;
        [MarshalAs(UnmanagedType.I4)]
        public int price;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string narration;
        [MarshalAs(UnmanagedType.I4)]
        public int duration;
    }
    public partial class Form1 : Form
    {
        [DllImport("LibraryBooks", CharSet = CharSet.Ansi)]
        static extern void GetClassInfo_(ref ClassInfo st, int i);


        [DllImport("LibraryBooks", CharSet = CharSet.Ansi)]
        static extern void SetClassInfo(ref ClassInfo st, int i);


        [DllImport("LibraryBooks", CharSet = CharSet.Ansi)]
        static extern int GetlibSize();


        [DllImport("LibraryBooks", CharSet = CharSet.Ansi)]
        static extern void Erase(int i);


        [DllImport("LibraryBooks", CharSet = CharSet.Ansi)]
        static extern void AddBook();


        [DllImport("LibraryBooks", CharSet = CharSet.Ansi)]
        static extern void AddAudioBook();


        [DllImport("LibraryBooks", CharSet = CharSet.Ansi)]
        static extern void SaveBook(StringBuilder fileName);


        [DllImport("LibraryBooks", CharSet = CharSet.Ansi)]
        static extern void LoadBook(StringBuilder fileName);

        ClassInfo info;
        int currentIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateBookList()
        {
            LBMemNames.Items.Clear();
            int size = GetlibSize();

            for (int i = 0; i < size; ++i)
            {
                GetClassInfo_(ref info, i);
                LBMemNames.Items.Add(info.name);
            }
        }
        private void ClearTable()
        {
            AuthorBook.Text = String.Empty;
            NameBook.Text = String.Empty;
            PagesBook.Text = String.Empty;
            PriceBook.Text = String.Empty;
            NarrationBook.Text = String.Empty;
            NarrationBook.Enabled = false;
            DurationBook.Text = String.Empty;
            DurationBook.Enabled = false;
        }

        private void AuthorBook_TextChanged(object sender, EventArgs e)
        {
            info.author = AuthorBook.Text;
        }

        private void NameBook_TextChanged(object sender, EventArgs e)
        {
            info.name = NameBook.Text;
        }

        private void PagesBook_TextChanged(object sender, EventArgs e)
        {
            try
            {
                info.pages = (int)Convert.ToUInt32(PagesBook.Text);
            }
            catch
            {
                info.pages = 0;
            }
        }

        private void PriceBook_TextChanged(object sender, EventArgs e)
        {
            try
            {
                info.price = (int)Convert.ToUInt32(PriceBook.Text);
            }
            catch
            {
                info.price = 0;
            }
        }

        private void NarrationBook_TextChanged(object sender, EventArgs e)
        {
            info.narration = NarrationBook.Text;
        }

        private void DurationBook_TextChanged(object sender, EventArgs e)
        {
            try
            {
                info.duration = (int)Convert.ToUInt32(DurationBook.Text);
            }
            catch (Exception ex)
            {
                info.duration = 0;
            }
        }

        private void LBMemNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = LBMemNames.SelectedIndex;
            if (currentIndex == -1)
            {
                ClearTable();
                return;
            }
            GetClassInfo_(ref info, currentIndex);

            AuthorBook.Text = info.author;
            NameBook.Text = info.name;
            PagesBook.Text = Convert.ToString(info.pages);
            PriceBook.Text = Convert.ToString(info.price);

            if (info.isBaseClass)
            {
                NarrationBook.Text = String.Empty;
                NarrationBook.Enabled = false;
                DurationBook.Text = String.Empty;
                DurationBook.Enabled = false;
            }
            else
            {
                NarrationBook.Enabled = true;
                NarrationBook.Text = Convert.ToString(info.narration);
                DurationBook.Enabled = true;
                DurationBook.Text = Convert.ToString(info.duration);
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddBook();
            UpdateBookList();
            LBMemNames.SelectedIndex = LBMemNames.Items.Count - 1;
            currentIndex = LBMemNames.SelectedIndex;
        }

        private void AddAudiobookButton_Click(object sender, EventArgs e)
        {
            AddAudioBook();
            UpdateBookList();
            LBMemNames.SelectedIndex = LBMemNames.Items.Count - 1;
            currentIndex = LBMemNames.SelectedIndex;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            currentIndex = LBMemNames.SelectedIndex;
            if (currentIndex == -1)
                return;

            SetClassInfo(ref info, currentIndex);
            UpdateBookList();
            LBMemNames.SelectedIndex = currentIndex;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            currentIndex = LBMemNames.SelectedIndex;
            int tmp = currentIndex;
            if (currentIndex == -1)
                return;
            Erase(currentIndex);
            LBMemNames.Items.RemoveAt(currentIndex);
            currentIndex = tmp;
            if (LBMemNames.Items.Count == 0)
            {
                currentIndex = -1;
                return;
            }
            if (currentIndex == LBMemNames.Items.Count)
            {
                LBMemNames.SelectedIndex = LBMemNames.Items.Count - 1;
                currentIndex = LBMemNames.SelectedIndex;
            }
            else
            {
                LBMemNames.SelectedIndex = currentIndex;
                currentIndex = LBMemNames.SelectedIndex;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\SavedFiles";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder fileName = new StringBuilder(saveFileDialog.FileName);
                    SaveBook(fileName);
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\SavedFiles";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder fileName = new StringBuilder(openFileDialog.FileName);
                    LoadBook(fileName);
                    UpdateBookList();
                    int bookCount = GetlibSize(); // Получаем количество книг после загрузки
                    MessageBox.Show($"Количество книг в библиотеке: {bookCount}", "Загрузка завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
