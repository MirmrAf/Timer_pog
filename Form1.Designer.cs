namespace Timer_pog
{
    partial class LogOutTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOutTimer));
            timer_label = new Label();
            hours_mtb = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            minutes_mtb = new MaskedTextBox();
            label3 = new Label();
            seconds_mtb = new MaskedTextBox();
            start_button = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            CycleBox = new CheckBox();
            SuspendLayout();
            // 
            // timer_label
            // 
            timer_label.Font = new Font("Segoe UI", 18F);
            timer_label.Location = new Point(136, 20);
            timer_label.Name = "timer_label";
            timer_label.Size = new Size(257, 36);
            timer_label.TabIndex = 0;
            timer_label.Text = "time: 00:00:00";
            // 
            // hours_mtb
            // 
            hours_mtb.BorderStyle = BorderStyle.FixedSingle;
            hours_mtb.Location = new Point(12, 91);
            hours_mtb.Mask = "99";
            hours_mtb.Name = "hours_mtb";
            hours_mtb.Size = new Size(49, 23);
            hours_mtb.TabIndex = 1;
            hours_mtb.MaskInputRejected += hours_mtb_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "hours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "minutes";
            // 
            // minutes_mtb
            // 
            minutes_mtb.BorderStyle = BorderStyle.FixedSingle;
            minutes_mtb.Location = new Point(83, 91);
            minutes_mtb.Mask = "99";
            minutes_mtb.Name = "minutes_mtb";
            minutes_mtb.Size = new Size(49, 23);
            minutes_mtb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 73);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "seconds";
            // 
            // seconds_mtb
            // 
            seconds_mtb.BorderStyle = BorderStyle.FixedSingle;
            seconds_mtb.Location = new Point(158, 91);
            seconds_mtb.Mask = "99";
            seconds_mtb.Name = "seconds_mtb";
            seconds_mtb.Size = new Size(49, 23);
            seconds_mtb.TabIndex = 5;
            // 
            // start_button
            // 
            start_button.Location = new Point(12, 20);
            start_button.Name = "start_button";
            start_button.Size = new Size(75, 23);
            start_button.TabIndex = 7;
            start_button.Text = "start";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 49);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 130);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "some sounds?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 108);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 11;
            label4.Text = "Key select";
            label4.Visible = false;
            // 
            // CycleBox
            // 
            CycleBox.AutoSize = true;
            CycleBox.Location = new Point(220, 86);
            CycleBox.Name = "CycleBox";
            CycleBox.Size = new Size(60, 19);
            CycleBox.TabIndex = 12;
            CycleBox.Text = "Cycle?";
            CycleBox.UseVisualStyleBackColor = true;
            CycleBox.CheckedChanged += CycleBox_CheckedChanged;
            // 
            // LogOutTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 161);
            Controls.Add(CycleBox);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(start_button);
            Controls.Add(label3);
            Controls.Add(seconds_mtb);
            Controls.Add(label2);
            Controls.Add(minutes_mtb);
            Controls.Add(label1);
            Controls.Add(hours_mtb);
            Controls.Add(timer_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LogOutTimer";
            RightToLeftLayout = true;
            Text = "Log Out Timer!";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timer_label;
        private MaskedTextBox hours_mtb;
        private Label label1;
        private Label label2;
        private MaskedTextBox minutes_mtb;
        private Label label3;
        private MaskedTextBox seconds_mtb;
        private Button start_button;
        private Button button1;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label4;
        private CheckBox CycleBox;
    }
}
