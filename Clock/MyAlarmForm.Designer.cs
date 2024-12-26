namespace Clock
{
	partial class MyAlarmForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.Alarm = new System.Windows.Forms.Label();
			this.AlarmTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SetAnAlarm = new System.Windows.Forms.Button();
			this.StopTheAlarm = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Alarm
			// 
			this.Alarm.AutoSize = true;
			this.Alarm.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Alarm.Location = new System.Drawing.Point(43, 29);
			this.Alarm.Name = "Alarm";
			this.Alarm.Size = new System.Drawing.Size(181, 55);
			this.Alarm.TabIndex = 0;
			this.Alarm.Text = "Alarm";
			// 
			// AlarmTextBox
			// 
			this.AlarmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AlarmTextBox.Location = new System.Drawing.Point(88, 87);
			this.AlarmTextBox.Mask = "00:00";
			this.AlarmTextBox.Name = "AlarmTextBox";
			this.AlarmTextBox.Size = new System.Drawing.Size(97, 49);
			this.AlarmTextBox.TabIndex = 1;
			this.AlarmTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// SetAnAlarm
			// 
			this.SetAnAlarm.Location = new System.Drawing.Point(75, 171);
			this.SetAnAlarm.Name = "SetAnAlarm";
			this.SetAnAlarm.Size = new System.Drawing.Size(124, 23);
			this.SetAnAlarm.TabIndex = 2;
			this.SetAnAlarm.Text = "Завести будильник";
			this.SetAnAlarm.UseVisualStyleBackColor = true;
			// 
			// StopTheAlarm
			// 
			this.StopTheAlarm.Location = new System.Drawing.Point(53, 200);
			this.StopTheAlarm.Name = "StopTheAlarm";
			this.StopTheAlarm.Size = new System.Drawing.Size(171, 42);
			this.StopTheAlarm.TabIndex = 3;
			this.StopTheAlarm.Text = "Остановить будильник";
			this.StopTheAlarm.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(119, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// AlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 259);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.StopTheAlarm);
			this.Controls.Add(this.SetAnAlarm);
			this.Controls.Add(this.AlarmTextBox);
			this.Controls.Add(this.Alarm);
			this.Name = "AlarmForm";
			this.Text = "Alarm";
			this.Load += new System.EventHandler(this.AlarmForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label Alarm;
		private System.Windows.Forms.MaskedTextBox AlarmTextBox;
		private System.Windows.Forms.Button SetAnAlarm;
		private System.Windows.Forms.Button StopTheAlarm;
		private System.Windows.Forms.Label label1;
	}
}