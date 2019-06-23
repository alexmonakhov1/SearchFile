namespace SearchFile
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
            this.textBoxFullPath = new System.Windows.Forms.TextBox();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCleanTextBox = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelFileBeingProcessing = new System.Windows.Forms.Label();
            this.labelCountProcessed = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonStopSearch = new System.Windows.Forms.Button();
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.labelPauseResume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFullPath
            // 
            this.textBoxFullPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullPath.Location = new System.Drawing.Point(12, 32);
            this.textBoxFullPath.Name = "textBoxFullPath";
            this.textBoxFullPath.Size = new System.Drawing.Size(424, 27);
            this.textBoxFullPath.TabIndex = 0;
            this.textBoxFullPath.TextChanged += new System.EventHandler(this.textBoxFullPath_TextChanged);
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPattern.Location = new System.Drawing.Point(12, 85);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(424, 27);
            this.textBoxPattern.TabIndex = 1;
            this.textBoxPattern.TextChanged += new System.EventHandler(this.textBoxPattern_TextChanged);
            // 
            // textBoxText
            // 
            this.textBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxText.Location = new System.Drawing.Point(12, 138);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(424, 27);
            this.textBoxText.TabIndex = 2;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Pattern";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input Text in File";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(12, 171);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(424, 59);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonCleanTextBox
            // 
            this.buttonCleanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCleanTextBox.Location = new System.Drawing.Point(12, 356);
            this.buttonCleanTextBox.Name = "buttonCleanTextBox";
            this.buttonCleanTextBox.Size = new System.Drawing.Size(424, 59);
            this.buttonCleanTextBox.TabIndex = 8;
            this.buttonCleanTextBox.Text = "Clean TextBox";
            this.buttonCleanTextBox.UseVisualStyleBackColor = true;
            this.buttonCleanTextBox.Click += new System.EventHandler(this.buttonCleanTextBox_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(12, 421);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(424, 59);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelFileBeingProcessing
            // 
            this.labelFileBeingProcessing.AutoSize = true;
            this.labelFileBeingProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileBeingProcessing.Location = new System.Drawing.Point(461, 9);
            this.labelFileBeingProcessing.Name = "labelFileBeingProcessing";
            this.labelFileBeingProcessing.Size = new System.Drawing.Size(173, 20);
            this.labelFileBeingProcessing.TabIndex = 10;
            this.labelFileBeingProcessing.Text = "FileBeingProcessing: ";
            this.labelFileBeingProcessing.Visible = false;
            // 
            // labelCountProcessed
            // 
            this.labelCountProcessed.AutoSize = true;
            this.labelCountProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountProcessed.Location = new System.Drawing.Point(461, 50);
            this.labelCountProcessed.Name = "labelCountProcessed";
            this.labelCountProcessed.Size = new System.Drawing.Size(143, 20);
            this.labelCountProcessed.TabIndex = 11;
            this.labelCountProcessed.Text = "CountProcessed: ";
            this.labelCountProcessed.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(461, 85);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(56, 20);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Time: ";
            this.labelTime.Visible = false;
            // 
            // buttonStopSearch
            // 
            this.buttonStopSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStopSearch.Location = new System.Drawing.Point(12, 236);
            this.buttonStopSearch.Name = "buttonStopSearch";
            this.buttonStopSearch.Size = new System.Drawing.Size(424, 59);
            this.buttonStopSearch.TabIndex = 13;
            this.buttonStopSearch.Text = "Stop Search";
            this.buttonStopSearch.UseVisualStyleBackColor = true;
            this.buttonStopSearch.Click += new System.EventHandler(this.buttonStopSearch_Click);
            // 
            // treeViewMain
            // 
            this.treeViewMain.Location = new System.Drawing.Point(451, 115);
            this.treeViewMain.Name = "treeViewMain";
            this.treeViewMain.Size = new System.Drawing.Size(800, 365);
            this.treeViewMain.TabIndex = 14;
            // 
            // labelPauseResume
            // 
            this.labelPauseResume.AutoSize = true;
            this.labelPauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPauseResume.ForeColor = System.Drawing.Color.Red;
            this.labelPauseResume.Location = new System.Drawing.Point(1166, 78);
            this.labelPauseResume.Name = "labelPauseResume";
            this.labelPauseResume.Size = new System.Drawing.Size(86, 29);
            this.labelPauseResume.TabIndex = 15;
            this.labelPauseResume.Text = "Pause";
            this.labelPauseResume.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 496);
            this.Controls.Add(this.labelPauseResume);
            this.Controls.Add(this.treeViewMain);
            this.Controls.Add(this.buttonStopSearch);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCountProcessed);
            this.Controls.Add(this.labelFileBeingProcessing);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCleanTextBox);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxPattern);
            this.Controls.Add(this.textBoxFullPath);
            this.Name = "Form1";
            this.Text = "Search Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFullPath;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCleanTextBox;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelFileBeingProcessing;
        private System.Windows.Forms.Label labelCountProcessed;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonStopSearch;
        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.Label labelPauseResume;
    }
}

