namespace lab6_Saklakova
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DurationBook = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.Label();
            this.NarrationBook = new System.Windows.Forms.TextBox();
            this.Narration = new System.Windows.Forms.Label();
            this.PriceBook = new System.Windows.Forms.TextBox();
            this.PagesBook = new System.Windows.Forms.TextBox();
            this.NameBook = new System.Windows.Forms.TextBox();
            this.AuthorBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBMemNames = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddAudiobookButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DurationBook
            // 
            this.DurationBook.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationBook.Location = new System.Drawing.Point(790, 438);
            this.DurationBook.Name = "DurationBook";
            this.DurationBook.Size = new System.Drawing.Size(381, 32);
            this.DurationBook.TabIndex = 67;
            this.DurationBook.TextChanged += new System.EventHandler(this.DurationBook_TextChanged);
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Duration.Location = new System.Drawing.Point(520, 438);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(248, 28);
            this.Duration.TabIndex = 66;
            this.Duration.Text = "Продолжительность";
            // 
            // NarrationBook
            // 
            this.NarrationBook.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NarrationBook.Location = new System.Drawing.Point(790, 382);
            this.NarrationBook.Name = "NarrationBook";
            this.NarrationBook.Size = new System.Drawing.Size(381, 32);
            this.NarrationBook.TabIndex = 65;
            this.NarrationBook.TextChanged += new System.EventHandler(this.NarrationBook_TextChanged);
            // 
            // Narration
            // 
            this.Narration.AutoSize = true;
            this.Narration.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Narration.Location = new System.Drawing.Point(687, 386);
            this.Narration.Name = "Narration";
            this.Narration.Size = new System.Drawing.Size(69, 28);
            this.Narration.TabIndex = 64;
            this.Narration.Text = "Чтец";
            // 
            // PriceBook
            // 
            this.PriceBook.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceBook.Location = new System.Drawing.Point(790, 325);
            this.PriceBook.Margin = new System.Windows.Forms.Padding(4);
            this.PriceBook.Name = "PriceBook";
            this.PriceBook.Size = new System.Drawing.Size(381, 32);
            this.PriceBook.TabIndex = 63;
            this.PriceBook.TextChanged += new System.EventHandler(this.PriceBook_TextChanged);
            // 
            // PagesBook
            // 
            this.PagesBook.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PagesBook.Location = new System.Drawing.Point(790, 273);
            this.PagesBook.Margin = new System.Windows.Forms.Padding(4);
            this.PagesBook.Name = "PagesBook";
            this.PagesBook.Size = new System.Drawing.Size(381, 32);
            this.PagesBook.TabIndex = 62;
            this.PagesBook.TextChanged += new System.EventHandler(this.PagesBook_TextChanged);
            // 
            // NameBook
            // 
            this.NameBook.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBook.Location = new System.Drawing.Point(790, 219);
            this.NameBook.Margin = new System.Windows.Forms.Padding(4);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(381, 32);
            this.NameBook.TabIndex = 61;
            this.NameBook.TextChanged += new System.EventHandler(this.NameBook_TextChanged);
            // 
            // AuthorBook
            // 
            this.AuthorBook.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorBook.Location = new System.Drawing.Point(790, 163);
            this.AuthorBook.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorBook.Name = "AuthorBook";
            this.AuthorBook.Size = new System.Drawing.Size(381, 32);
            this.AuthorBook.TabIndex = 60;
            this.AuthorBook.TextChanged += new System.EventHandler(this.AuthorBook_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(686, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 59;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(566, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 58;
            this.label3.Text = "Кол-во страниц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(635, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 57;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(674, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 56;
            this.label1.Text = "Автор";
            // 
            // LBMemNames
            // 
            this.LBMemNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBMemNames.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBMemNames.FormattingEnabled = true;
            this.LBMemNames.HorizontalScrollbar = true;
            this.LBMemNames.ItemHeight = 28;
            this.LBMemNames.Location = new System.Drawing.Point(26, 45);
            this.LBMemNames.Margin = new System.Windows.Forms.Padding(4);
            this.LBMemNames.Name = "LBMemNames";
            this.LBMemNames.ScrollAlwaysVisible = true;
            this.LBMemNames.Size = new System.Drawing.Size(446, 508);
            this.LBMemNames.TabIndex = 68;
            this.LBMemNames.SelectedIndexChanged += new System.EventHandler(this.LBMemNames_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(844, 634);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(257, 41);
            this.DeleteButton.TabIndex = 72;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(844, 584);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(257, 41);
            this.EditButton.TabIndex = 71;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddAudiobookButton
            // 
            this.AddAudiobookButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddAudiobookButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAudiobookButton.Location = new System.Drawing.Point(844, 535);
            this.AddAudiobookButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddAudiobookButton.Name = "AddAudiobookButton";
            this.AddAudiobookButton.Size = new System.Drawing.Size(257, 41);
            this.AddAudiobookButton.TabIndex = 70;
            this.AddAudiobookButton.Text = "Добавить аудиокнигу";
            this.AddAudiobookButton.UseVisualStyleBackColor = false;
            this.AddAudiobookButton.Click += new System.EventHandler(this.AddAudiobookButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddBookButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBookButton.Location = new System.Drawing.Point(844, 487);
            this.AddBookButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(257, 41);
            this.AddBookButton.TabIndex = 69;
            this.AddBookButton.Text = "Добавить книгу";
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(140, 631);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(173, 41);
            this.LoadButton.TabIndex = 74;
            this.LoadButton.Text = "ЗАГРУЗИТЬ";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(140, 581);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(173, 41);
            this.SaveButton.TabIndex = 73;
            this.SaveButton.Text = "СОХРАНИТЬ";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(724, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 32);
            this.label5.TabIndex = 76;
            this.label5.Text = "Информация о книге:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1073, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 699);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddAudiobookButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.LBMemNames);
            this.Controls.Add(this.DurationBook);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.NarrationBook);
            this.Controls.Add(this.Narration);
            this.Controls.Add(this.PriceBook);
            this.Controls.Add(this.PagesBook);
            this.Controls.Add(this.NameBook);
            this.Controls.Add(this.AuthorBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DurationBook;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.TextBox NarrationBook;
        private System.Windows.Forms.Label Narration;
        private System.Windows.Forms.TextBox PriceBook;
        private System.Windows.Forms.TextBox PagesBook;
        private System.Windows.Forms.TextBox NameBook;
        private System.Windows.Forms.TextBox AuthorBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBMemNames;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddAudiobookButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

