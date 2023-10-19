namespace Voice_Recorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bRecord = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.lRec = new System.Windows.Forms.Label();
            this.lTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bRecord
            // 
            this.bRecord.BackColor = System.Drawing.Color.Transparent;
            this.bRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRecord.Location = new System.Drawing.Point(26, 54);
            this.bRecord.Name = "bRecord";
            this.bRecord.Size = new System.Drawing.Size(117, 37);
            this.bRecord.TabIndex = 0;
            this.bRecord.Text = "Record";
            this.bRecord.UseVisualStyleBackColor = false;
            this.bRecord.Click += new System.EventHandler(this.bRecord_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Transparent;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Location = new System.Drawing.Point(166, 54);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(115, 37);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bPlay
            // 
            this.bPlay.BackColor = System.Drawing.Color.Transparent;
            this.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlay.Location = new System.Drawing.Point(306, 54);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(114, 37);
            this.bPlay.TabIndex = 2;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = false;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // lRec
            // 
            this.lRec.AutoSize = true;
            this.lRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRec.Location = new System.Drawing.Point(23, 18);
            this.lRec.Name = "lRec";
            this.lRec.Size = new System.Drawing.Size(116, 16);
            this.lRec.TabIndex = 3;
            this.lRec.Text = "Voice Recorder";
            // 
            // lTimer
            // 
            this.lTimer.AutoSize = true;
            this.lTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTimer.Location = new System.Drawing.Point(228, 18);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(133, 16);
            this.lTimer.TabIndex = 4;
            this.lTimer.Text = "Duration : 00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 103);
            this.Controls.Add(this.lTimer);
            this.Controls.Add(this.lRec);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRecord;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Label lRec;
        private System.Windows.Forms.Label lTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

