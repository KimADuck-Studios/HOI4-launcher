
namespace hoi4_launcher
{
    partial class Form1
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
            this.setLocations_panel = new System.Windows.Forms.Panel();
            this.hoi4_exe_location_button = new System.Windows.Forms.Button();
            this.hoi4_exe_location_textbox = new System.Windows.Forms.TextBox();
            this.hoi4_mod_location_button = new System.Windows.Forms.Button();
            this.hoi4_location_textbox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mod_selection_panel = new System.Windows.Forms.Panel();
            this.filter_mods_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_all_mods_button = new System.Windows.Forms.Button();
            this.remove_selected_mod_button = new System.Windows.Forms.Button();
            this.add_selected_mod_button = new System.Windows.Forms.Button();
            this.playset_listbox = new System.Windows.Forms.ListBox();
            this.allMods_listbox = new System.Windows.Forms.ListBox();
            this.launch_panel = new System.Windows.Forms.Panel();
            this.launch_game_button = new System.Windows.Forms.Button();
            this.launch_debug_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HOI4_dlc_selection_panel = new System.Windows.Forms.Panel();
            this.HOI4_all_dlc_listbox = new System.Windows.Forms.ListBox();
            this.hoi4_enabled_dlc_listbox = new System.Windows.Forms.ListBox();
            this.HOI4_add_dlc_button = new System.Windows.Forms.Button();
            this.HOI4_remove_dlc_button = new System.Windows.Forms.Button();
            this.HOI4_enable_all_dlc_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.setLocations_panel.SuspendLayout();
            this.mod_selection_panel.SuspendLayout();
            this.launch_panel.SuspendLayout();
            this.HOI4_dlc_selection_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // setLocations_panel
            // 
            this.setLocations_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setLocations_panel.Controls.Add(this.hoi4_exe_location_button);
            this.setLocations_panel.Controls.Add(this.hoi4_exe_location_textbox);
            this.setLocations_panel.Controls.Add(this.hoi4_mod_location_button);
            this.setLocations_panel.Controls.Add(this.hoi4_location_textbox);
            this.setLocations_panel.Location = new System.Drawing.Point(13, 12);
            this.setLocations_panel.Name = "setLocations_panel";
            this.setLocations_panel.Size = new System.Drawing.Size(220, 55);
            this.setLocations_panel.TabIndex = 0;
            // 
            // hoi4_exe_location_button
            // 
            this.hoi4_exe_location_button.Location = new System.Drawing.Point(189, 29);
            this.hoi4_exe_location_button.Name = "hoi4_exe_location_button";
            this.hoi4_exe_location_button.Size = new System.Drawing.Size(25, 20);
            this.hoi4_exe_location_button.TabIndex = 3;
            this.hoi4_exe_location_button.Text = "...";
            this.hoi4_exe_location_button.UseVisualStyleBackColor = true;
            this.hoi4_exe_location_button.Click += new System.EventHandler(this.hoi4_exe_location_button_Click);
            // 
            // hoi4_exe_location_textbox
            // 
            this.hoi4_exe_location_textbox.Location = new System.Drawing.Point(3, 29);
            this.hoi4_exe_location_textbox.Name = "hoi4_exe_location_textbox";
            this.hoi4_exe_location_textbox.Size = new System.Drawing.Size(180, 20);
            this.hoi4_exe_location_textbox.TabIndex = 2;
            this.hoi4_exe_location_textbox.Text = "HOI4 exe";
            // 
            // hoi4_mod_location_button
            // 
            this.hoi4_mod_location_button.Location = new System.Drawing.Point(189, 3);
            this.hoi4_mod_location_button.Name = "hoi4_mod_location_button";
            this.hoi4_mod_location_button.Size = new System.Drawing.Size(25, 20);
            this.hoi4_mod_location_button.TabIndex = 1;
            this.hoi4_mod_location_button.Text = "...";
            this.hoi4_mod_location_button.UseVisualStyleBackColor = true;
            this.hoi4_mod_location_button.Click += new System.EventHandler(this.hoi4_mod_location_button_Click);
            // 
            // hoi4_location_textbox
            // 
            this.hoi4_location_textbox.Location = new System.Drawing.Point(3, 3);
            this.hoi4_location_textbox.Name = "hoi4_location_textbox";
            this.hoi4_location_textbox.Size = new System.Drawing.Size(180, 20);
            this.hoi4_location_textbox.TabIndex = 0;
            this.hoi4_location_textbox.Text = "HOI4 folder";
            // 
            // mod_selection_panel
            // 
            this.mod_selection_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mod_selection_panel.Controls.Add(this.filter_mods_textbox);
            this.mod_selection_panel.Controls.Add(this.label2);
            this.mod_selection_panel.Controls.Add(this.label1);
            this.mod_selection_panel.Controls.Add(this.remove_all_mods_button);
            this.mod_selection_panel.Controls.Add(this.remove_selected_mod_button);
            this.mod_selection_panel.Controls.Add(this.add_selected_mod_button);
            this.mod_selection_panel.Controls.Add(this.playset_listbox);
            this.mod_selection_panel.Controls.Add(this.allMods_listbox);
            this.mod_selection_panel.Location = new System.Drawing.Point(239, 12);
            this.mod_selection_panel.Name = "mod_selection_panel";
            this.mod_selection_panel.Size = new System.Drawing.Size(537, 302);
            this.mod_selection_panel.TabIndex = 2;
            // 
            // filter_mods_textbox
            // 
            this.filter_mods_textbox.Location = new System.Drawing.Point(221, 16);
            this.filter_mods_textbox.Name = "filter_mods_textbox";
            this.filter_mods_textbox.Size = new System.Drawing.Size(93, 20);
            this.filter_mods_textbox.TabIndex = 10;
            this.filter_mods_textbox.Text = "Filter mods";
            this.filter_mods_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enabled mods";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "All installed mods";
            // 
            // remove_all_mods_button
            // 
            this.remove_all_mods_button.Location = new System.Drawing.Point(221, 238);
            this.remove_all_mods_button.Name = "remove_all_mods_button";
            this.remove_all_mods_button.Size = new System.Drawing.Size(93, 53);
            this.remove_all_mods_button.TabIndex = 7;
            this.remove_all_mods_button.Text = "Remove all mods from playset";
            this.remove_all_mods_button.UseVisualStyleBackColor = true;
            this.remove_all_mods_button.Click += new System.EventHandler(this.remove_all_mods_button_Click);
            // 
            // remove_selected_mod_button
            // 
            this.remove_selected_mod_button.Location = new System.Drawing.Point(221, 153);
            this.remove_selected_mod_button.Name = "remove_selected_mod_button";
            this.remove_selected_mod_button.Size = new System.Drawing.Size(93, 53);
            this.remove_selected_mod_button.TabIndex = 6;
            this.remove_selected_mod_button.Text = "Remove selected mod from playset";
            this.remove_selected_mod_button.UseVisualStyleBackColor = true;
            this.remove_selected_mod_button.Click += new System.EventHandler(this.remove_selected_mod_button_Click);
            // 
            // add_selected_mod_button
            // 
            this.add_selected_mod_button.Location = new System.Drawing.Point(221, 68);
            this.add_selected_mod_button.Name = "add_selected_mod_button";
            this.add_selected_mod_button.Size = new System.Drawing.Size(93, 53);
            this.add_selected_mod_button.TabIndex = 5;
            this.add_selected_mod_button.Text = "Add selected mod to playset";
            this.add_selected_mod_button.UseVisualStyleBackColor = true;
            this.add_selected_mod_button.Click += new System.EventHandler(this.add_selected_mod_button_Click);
            // 
            // playset_listbox
            // 
            this.playset_listbox.FormattingEnabled = true;
            this.playset_listbox.Location = new System.Drawing.Point(320, 16);
            this.playset_listbox.Name = "playset_listbox";
            this.playset_listbox.Size = new System.Drawing.Size(212, 277);
            this.playset_listbox.TabIndex = 4;
            // 
            // allMods_listbox
            // 
            this.allMods_listbox.FormattingEnabled = true;
            this.allMods_listbox.Location = new System.Drawing.Point(3, 16);
            this.allMods_listbox.Name = "allMods_listbox";
            this.allMods_listbox.Size = new System.Drawing.Size(212, 277);
            this.allMods_listbox.TabIndex = 3;
            // 
            // launch_panel
            // 
            this.launch_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launch_panel.Controls.Add(this.launch_game_button);
            this.launch_panel.Controls.Add(this.launch_debug_button);
            this.launch_panel.Location = new System.Drawing.Point(239, 320);
            this.launch_panel.Name = "launch_panel";
            this.launch_panel.Size = new System.Drawing.Size(537, 100);
            this.launch_panel.TabIndex = 3;
            // 
            // launch_game_button
            // 
            this.launch_game_button.Location = new System.Drawing.Point(3, 3);
            this.launch_game_button.Name = "launch_game_button";
            this.launch_game_button.Size = new System.Drawing.Size(212, 92);
            this.launch_game_button.TabIndex = 5;
            this.launch_game_button.Text = "LAUNCH GAME";
            this.launch_game_button.UseVisualStyleBackColor = true;
            this.launch_game_button.Click += new System.EventHandler(this.launch_game_button_Click);
            // 
            // launch_debug_button
            // 
            this.launch_debug_button.Location = new System.Drawing.Point(320, 3);
            this.launch_debug_button.Name = "launch_debug_button";
            this.launch_debug_button.Size = new System.Drawing.Size(212, 92);
            this.launch_debug_button.TabIndex = 4;
            this.launch_debug_button.Text = "LAUNCH DEBUG";
            this.launch_debug_button.UseVisualStyleBackColor = true;
            this.launch_debug_button.Click += new System.EventHandler(this.launch_debug_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // HOI4_dlc_selection_panel
            // 
            this.HOI4_dlc_selection_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HOI4_dlc_selection_panel.Controls.Add(this.label4);
            this.HOI4_dlc_selection_panel.Controls.Add(this.label3);
            this.HOI4_dlc_selection_panel.Controls.Add(this.HOI4_enable_all_dlc_button);
            this.HOI4_dlc_selection_panel.Controls.Add(this.HOI4_remove_dlc_button);
            this.HOI4_dlc_selection_panel.Controls.Add(this.HOI4_add_dlc_button);
            this.HOI4_dlc_selection_panel.Controls.Add(this.hoi4_enabled_dlc_listbox);
            this.HOI4_dlc_selection_panel.Controls.Add(this.HOI4_all_dlc_listbox);
            this.HOI4_dlc_selection_panel.Location = new System.Drawing.Point(13, 73);
            this.HOI4_dlc_selection_panel.Name = "HOI4_dlc_selection_panel";
            this.HOI4_dlc_selection_panel.Size = new System.Drawing.Size(220, 347);
            this.HOI4_dlc_selection_panel.TabIndex = 4;
            // 
            // HOI4_all_dlc_listbox
            // 
            this.HOI4_all_dlc_listbox.FormattingEnabled = true;
            this.HOI4_all_dlc_listbox.Location = new System.Drawing.Point(2, 16);
            this.HOI4_all_dlc_listbox.Name = "HOI4_all_dlc_listbox";
            this.HOI4_all_dlc_listbox.Size = new System.Drawing.Size(211, 95);
            this.HOI4_all_dlc_listbox.TabIndex = 11;
            // 
            // hoi4_enabled_dlc_listbox
            // 
            this.hoi4_enabled_dlc_listbox.FormattingEnabled = true;
            this.hoi4_enabled_dlc_listbox.Location = new System.Drawing.Point(3, 128);
            this.hoi4_enabled_dlc_listbox.Name = "hoi4_enabled_dlc_listbox";
            this.hoi4_enabled_dlc_listbox.Size = new System.Drawing.Size(211, 95);
            this.hoi4_enabled_dlc_listbox.TabIndex = 12;
            // 
            // HOI4_add_dlc_button
            // 
            this.HOI4_add_dlc_button.Location = new System.Drawing.Point(2, 270);
            this.HOI4_add_dlc_button.Name = "HOI4_add_dlc_button";
            this.HOI4_add_dlc_button.Size = new System.Drawing.Size(211, 33);
            this.HOI4_add_dlc_button.TabIndex = 13;
            this.HOI4_add_dlc_button.Text = "Enable selected DLC";
            this.HOI4_add_dlc_button.UseVisualStyleBackColor = true;
            this.HOI4_add_dlc_button.Click += new System.EventHandler(this.HOI4_add_dlc_button_Click);
            // 
            // HOI4_remove_dlc_button
            // 
            this.HOI4_remove_dlc_button.Location = new System.Drawing.Point(2, 229);
            this.HOI4_remove_dlc_button.Name = "HOI4_remove_dlc_button";
            this.HOI4_remove_dlc_button.Size = new System.Drawing.Size(211, 33);
            this.HOI4_remove_dlc_button.TabIndex = 14;
            this.HOI4_remove_dlc_button.Text = "Disable selected dlc";
            this.HOI4_remove_dlc_button.UseVisualStyleBackColor = true;
            this.HOI4_remove_dlc_button.Click += new System.EventHandler(this.HOI4_remove_dlc_button_Click);
            // 
            // HOI4_enable_all_dlc_button
            // 
            this.HOI4_enable_all_dlc_button.Location = new System.Drawing.Point(3, 309);
            this.HOI4_enable_all_dlc_button.Name = "HOI4_enable_all_dlc_button";
            this.HOI4_enable_all_dlc_button.Size = new System.Drawing.Size(211, 33);
            this.HOI4_enable_all_dlc_button.TabIndex = 15;
            this.HOI4_enable_all_dlc_button.Text = "Enable all DLCs";
            this.HOI4_enable_all_dlc_button.UseVisualStyleBackColor = true;
            this.HOI4_enable_all_dlc_button.Click += new System.EventHandler(this.HOI4_enable_all_dlc_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "All DLCs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enabled DLCs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 431);
            this.Controls.Add(this.HOI4_dlc_selection_panel);
            this.Controls.Add(this.launch_panel);
            this.Controls.Add(this.mod_selection_panel);
            this.Controls.Add(this.setLocations_panel);
            this.Name = "Form1";
            this.Text = "Anyzooka\'s HOI4 Launcher";
            this.setLocations_panel.ResumeLayout(false);
            this.setLocations_panel.PerformLayout();
            this.mod_selection_panel.ResumeLayout(false);
            this.mod_selection_panel.PerformLayout();
            this.launch_panel.ResumeLayout(false);
            this.HOI4_dlc_selection_panel.ResumeLayout(false);
            this.HOI4_dlc_selection_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel setLocations_panel;
        private System.Windows.Forms.Button hoi4_mod_location_button;
        private System.Windows.Forms.TextBox hoi4_location_textbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel mod_selection_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_all_mods_button;
        private System.Windows.Forms.Button remove_selected_mod_button;
        private System.Windows.Forms.Button add_selected_mod_button;
        private System.Windows.Forms.ListBox playset_listbox;
        private System.Windows.Forms.ListBox allMods_listbox;
        private System.Windows.Forms.TextBox filter_mods_textbox;
        private System.Windows.Forms.Panel launch_panel;
        private System.Windows.Forms.Button launch_game_button;
        private System.Windows.Forms.Button launch_debug_button;
        private System.Windows.Forms.Button hoi4_exe_location_button;
        private System.Windows.Forms.TextBox hoi4_exe_location_textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel HOI4_dlc_selection_panel;
        private System.Windows.Forms.ListBox hoi4_enabled_dlc_listbox;
        private System.Windows.Forms.ListBox HOI4_all_dlc_listbox;
        private System.Windows.Forms.Button HOI4_remove_dlc_button;
        private System.Windows.Forms.Button HOI4_add_dlc_button;
        private System.Windows.Forms.Button HOI4_enable_all_dlc_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

