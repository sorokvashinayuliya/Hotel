namespace Hotel
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
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reserveredCheckBox = new System.Windows.Forms.CheckBox();
            this.availableСheckBox = new System.Windows.Forms.CheckBox();
            this.occupiedCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckOutCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RosterLabel = new System.Windows.Forms.Label();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.guestsTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(244, 529);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Location = new System.Drawing.Point(244, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(307, 529);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter3.Location = new System.Drawing.Point(551, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(427, 529);
            this.splitter3.TabIndex = 2;
            this.splitter3.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(244, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(527, 22);
            this.searchBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(713, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 33);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(12, 12);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(92, 32);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reserveredCheckBox
            // 
            this.reserveredCheckBox.AutoSize = true;
            this.reserveredCheckBox.Location = new System.Drawing.Point(18, 81);
            this.reserveredCheckBox.Name = "reserveredCheckBox";
            this.reserveredCheckBox.Size = new System.Drawing.Size(150, 20);
            this.reserveredCheckBox.TabIndex = 6;
            this.reserveredCheckBox.Text = "Зарезервировано";
            this.reserveredCheckBox.UseVisualStyleBackColor = true;
            this.reserveredCheckBox.CheckedChanged += new System.EventHandler(this.reserveredCheckBox_CheckedChanged);
            // 
            // availableСheckBox
            // 
            this.availableСheckBox.AutoSize = true;
            this.availableСheckBox.Location = new System.Drawing.Point(18, 122);
            this.availableСheckBox.Name = "availableСheckBox";
            this.availableСheckBox.Size = new System.Drawing.Size(103, 20);
            this.availableСheckBox.TabIndex = 7;
            this.availableСheckBox.Text = "Свободные";
            this.availableСheckBox.UseVisualStyleBackColor = true;
            this.availableСheckBox.CheckedChanged += new System.EventHandler(this.availableСheckBox_CheckedChanged);
            // 
            // occupiedCheckBox
            // 
            this.occupiedCheckBox.AutoSize = true;
            this.occupiedCheckBox.Location = new System.Drawing.Point(18, 162);
            this.occupiedCheckBox.Name = "occupiedCheckBox";
            this.occupiedCheckBox.Size = new System.Drawing.Size(77, 20);
            this.occupiedCheckBox.TabIndex = 8;
            this.occupiedCheckBox.Text = "Заняты";
            this.occupiedCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckOutCheckBox
            // 
            this.CheckOutCheckBox.AutoSize = true;
            this.CheckOutCheckBox.Location = new System.Drawing.Point(18, 199);
            this.CheckOutCheckBox.Name = "CheckOutCheckBox";
            this.CheckOutCheckBox.Size = new System.Drawing.Size(126, 20);
            this.CheckOutCheckBox.TabIndex = 9;
            this.CheckOutCheckBox.Text = "Выписываются";
            this.CheckOutCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Статус";
            // 
            // RosterLabel
            // 
            this.RosterLabel.AutoSize = true;
            this.RosterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RosterLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RosterLabel.Location = new System.Drawing.Point(302, 46);
            this.RosterLabel.Name = "RosterLabel";
            this.RosterLabel.Size = new System.Drawing.Size(203, 32);
            this.RosterLabel.TabIndex = 12;
            this.RosterLabel.Text = "Список гостей";
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RoomLabel.Location = new System.Drawing.Point(625, 46);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(109, 32);
            this.RoomLabel.TabIndex = 13;
            this.RoomLabel.Text = "Номер ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(597, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 186);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(590, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Статус";
            // 
            // guestsTextBox1
            // 
            this.guestsTextBox1.Location = new System.Drawing.Point(260, 103);
            this.guestsTextBox1.Name = "guestsTextBox1";
            this.guestsTextBox1.Size = new System.Drawing.Size(275, 405);
            this.guestsTextBox1.TabIndex = 16;
            this.guestsTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(242, 350);
            this.dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guestsTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RoomLabel);
            this.Controls.Add(this.RosterLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckOutCheckBox);
            this.Controls.Add(this.occupiedCheckBox);
            this.Controls.Add(this.availableСheckBox);
            this.Controls.Add(this.reserveredCheckBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox reserveredCheckBox;
        private System.Windows.Forms.CheckBox availableСheckBox;
        private System.Windows.Forms.CheckBox occupiedCheckBox;
        private System.Windows.Forms.CheckBox CheckOutCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RosterLabel;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox guestsTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

