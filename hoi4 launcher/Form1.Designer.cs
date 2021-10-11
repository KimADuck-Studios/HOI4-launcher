
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
            this.workshop_folder_button = new System.Windows.Forms.Button();
            this.workshop_folder_textbox = new System.Windows.Forms.TextBox();
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
            this.enabled_mods_listbox = new System.Windows.Forms.ListBox();
            this.allMods_listbox = new System.Windows.Forms.ListBox();
            this.launch_panel = new System.Windows.Forms.Panel();
            this.launch_game_button = new System.Windows.Forms.Button();
            this.launch_debug_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HOI4_dlc_selection_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HOI4_enable_all_dlc_button = new System.Windows.Forms.Button();
            this.HOI4_remove_dlc_button = new System.Windows.Forms.Button();
            this.HOI4_add_dlc_button = new System.Windows.Forms.Button();
            this.hoi4_enabled_dlc_listbox = new System.Windows.Forms.ListBox();
            this.HOI4_all_dlc_listbox = new System.Windows.Forms.ListBox();
            this.HOI4_playset_selector_panel = new System.Windows.Forms.Panel();
            this.playset_name_textbox = new System.Windows.Forms.TextBox();
            this.HOI4_playset_lisbox = new System.Windows.Forms.ListBox();
            this.load_playset_button = new System.Windows.Forms.Button();
            this.create_new_playset_button = new System.Windows.Forms.Button();
            this.modding_panel = new System.Windows.Forms.Panel();
            this.reload_workshop_mods_button = new System.Windows.Forms.Button();
            this.new_mod_name_textbox = new System.Windows.Forms.TextBox();
            this.create_new_mod_button = new System.Windows.Forms.Button();
            this.cmdArgs_textbox = new System.Windows.Forms.TextBox();
            this.setLocations_panel.SuspendLayout();
            this.mod_selection_panel.SuspendLayout();
            this.launch_panel.SuspendLayout();
            this.HOI4_dlc_selection_panel.SuspendLayout();
            this.HOI4_playset_selector_panel.SuspendLayout();
            this.modding_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // setLocations_panel
            // 
            this.setLocations_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setLocations_panel.Controls.Add(this.workshop_folder_button);
            this.setLocations_panel.Controls.Add(this.workshop_folder_textbox);
            this.setLocations_panel.Controls.Add(this.hoi4_exe_location_button);
            this.setLocations_panel.Controls.Add(this.hoi4_exe_location_textbox);
            this.setLocations_panel.Controls.Add(this.hoi4_mod_location_button);
            this.setLocations_panel.Controls.Add(this.hoi4_location_textbox);
            this.setLocations_panel.Location = new System.Drawing.Point(784, 312);
            this.setLocations_panel.Name = "setLocations_panel";
            this.setLocations_panel.Size = new System.Drawing.Size(320, 104);
            this.setLocations_panel.TabIndex = 0;
            // 
            // workshop_folder_button
            // 
            this.workshop_folder_button.Location = new System.Drawing.Point(288, 56);
            this.workshop_folder_button.Name = "workshop_folder_button";
            this.workshop_folder_button.Size = new System.Drawing.Size(25, 20);
            this.workshop_folder_button.TabIndex = 5;
            this.workshop_folder_button.Text = "...";
            this.workshop_folder_button.UseVisualStyleBackColor = true;
            // 
            // workshop_folder_textbox
            // 
            this.workshop_folder_textbox.Location = new System.Drawing.Point(8, 56);
            this.workshop_folder_textbox.Name = "workshop_folder_textbox";
            this.workshop_folder_textbox.Size = new System.Drawing.Size(272, 20);
            this.workshop_folder_textbox.TabIndex = 4;
            this.workshop_folder_textbox.Text = "HOI4 workshop folder";
            // 
            // hoi4_exe_location_button
            // 
            this.hoi4_exe_location_button.Location = new System.Drawing.Point(288, 32);
            this.hoi4_exe_location_button.Name = "hoi4_exe_location_button";
            this.hoi4_exe_location_button.Size = new System.Drawing.Size(25, 20);
            this.hoi4_exe_location_button.TabIndex = 3;
            this.hoi4_exe_location_button.Text = "...";
            this.hoi4_exe_location_button.UseVisualStyleBackColor = true;
            this.hoi4_exe_location_button.Click += new System.EventHandler(this.hoi4_exe_location_button_Click);
            // 
            // hoi4_exe_location_textbox
            // 
            this.hoi4_exe_location_textbox.Location = new System.Drawing.Point(8, 32);
            this.hoi4_exe_location_textbox.Name = "hoi4_exe_location_textbox";
            this.hoi4_exe_location_textbox.Size = new System.Drawing.Size(272, 20);
            this.hoi4_exe_location_textbox.TabIndex = 2;
            this.hoi4_exe_location_textbox.Text = "HOI4 exe";
            // 
            // hoi4_mod_location_button
            // 
            this.hoi4_mod_location_button.Location = new System.Drawing.Point(288, 8);
            this.hoi4_mod_location_button.Name = "hoi4_mod_location_button";
            this.hoi4_mod_location_button.Size = new System.Drawing.Size(25, 20);
            this.hoi4_mod_location_button.TabIndex = 1;
            this.hoi4_mod_location_button.Text = "...";
            this.hoi4_mod_location_button.UseVisualStyleBackColor = true;
            this.hoi4_mod_location_button.Click += new System.EventHandler(this.hoi4_mod_location_button_Click);
            // 
            // hoi4_location_textbox
            // 
            this.hoi4_location_textbox.Location = new System.Drawing.Point(8, 8);
            this.hoi4_location_textbox.Name = "hoi4_location_textbox";
            this.hoi4_location_textbox.Size = new System.Drawing.Size(272, 20);
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
            this.mod_selection_panel.Controls.Add(this.enabled_mods_listbox);
            this.mod_selection_panel.Controls.Add(this.allMods_listbox);
            this.mod_selection_panel.Location = new System.Drawing.Point(240, 8);
            this.mod_selection_panel.Name = "mod_selection_panel";
            this.mod_selection_panel.Size = new System.Drawing.Size(537, 300);
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
            // enabled_mods_listbox
            // 
            this.enabled_mods_listbox.FormattingEnabled = true;
            this.enabled_mods_listbox.Location = new System.Drawing.Point(328, 16);
            this.enabled_mods_listbox.Name = "enabled_mods_listbox";
            this.enabled_mods_listbox.Size = new System.Drawing.Size(200, 277);
            this.enabled_mods_listbox.TabIndex = 4;
            // 
            // allMods_listbox
            // 
            this.allMods_listbox.FormattingEnabled = true;
            this.allMods_listbox.Location = new System.Drawing.Point(8, 16);
            this.allMods_listbox.Name = "allMods_listbox";
            this.allMods_listbox.Size = new System.Drawing.Size(208, 277);
            this.allMods_listbox.TabIndex = 3;
            // 
            // launch_panel
            // 
            this.launch_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launch_panel.Controls.Add(this.cmdArgs_textbox);
            this.launch_panel.Controls.Add(this.launch_game_button);
            this.launch_panel.Controls.Add(this.launch_debug_button);
            this.launch_panel.Location = new System.Drawing.Point(240, 312);
            this.launch_panel.Name = "launch_panel";
            this.launch_panel.Size = new System.Drawing.Size(216, 104);
            this.launch_panel.TabIndex = 3;
            // 
            // launch_game_button
            // 
            this.launch_game_button.Location = new System.Drawing.Point(8, 8);
            this.launch_game_button.Name = "launch_game_button";
            this.launch_game_button.Size = new System.Drawing.Size(99, 29);
            this.launch_game_button.TabIndex = 5;
            this.launch_game_button.Text = "Launch Game";
            this.launch_game_button.UseVisualStyleBackColor = true;
            this.launch_game_button.Click += new System.EventHandler(this.launch_game_button_Click);
            // 
            // launch_debug_button
            // 
            this.launch_debug_button.Location = new System.Drawing.Point(112, 3);
            this.launch_debug_button.Name = "launch_debug_button";
            this.launch_debug_button.Size = new System.Drawing.Size(99, 13);
            this.launch_debug_button.TabIndex = 4;
            this.launch_debug_button.Text = "Launch Debug";
            this.launch_debug_button.UseVisualStyleBackColor = true;
            this.launch_debug_button.Visible = false;
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
            this.HOI4_dlc_selection_panel.Location = new System.Drawing.Point(8, 8);
            this.HOI4_dlc_selection_panel.Name = "HOI4_dlc_selection_panel";
            this.HOI4_dlc_selection_panel.Size = new System.Drawing.Size(224, 408);
            this.HOI4_dlc_selection_panel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enabled DLCs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "All DLCs";
            // 
            // HOI4_enable_all_dlc_button
            // 
            this.HOI4_enable_all_dlc_button.Location = new System.Drawing.Point(8, 366);
            this.HOI4_enable_all_dlc_button.Name = "HOI4_enable_all_dlc_button";
            this.HOI4_enable_all_dlc_button.Size = new System.Drawing.Size(208, 33);
            this.HOI4_enable_all_dlc_button.TabIndex = 15;
            this.HOI4_enable_all_dlc_button.Text = "Enable all DLCs";
            this.HOI4_enable_all_dlc_button.UseVisualStyleBackColor = true;
            this.HOI4_enable_all_dlc_button.Click += new System.EventHandler(this.HOI4_enable_all_dlc_button_Click);
            // 
            // HOI4_remove_dlc_button
            // 
            this.HOI4_remove_dlc_button.Location = new System.Drawing.Point(8, 272);
            this.HOI4_remove_dlc_button.Name = "HOI4_remove_dlc_button";
            this.HOI4_remove_dlc_button.Size = new System.Drawing.Size(208, 33);
            this.HOI4_remove_dlc_button.TabIndex = 14;
            this.HOI4_remove_dlc_button.Text = "Disable selected dlc";
            this.HOI4_remove_dlc_button.UseVisualStyleBackColor = true;
            this.HOI4_remove_dlc_button.Click += new System.EventHandler(this.HOI4_remove_dlc_button_Click);
            // 
            // HOI4_add_dlc_button
            // 
            this.HOI4_add_dlc_button.Location = new System.Drawing.Point(8, 319);
            this.HOI4_add_dlc_button.Name = "HOI4_add_dlc_button";
            this.HOI4_add_dlc_button.Size = new System.Drawing.Size(208, 33);
            this.HOI4_add_dlc_button.TabIndex = 13;
            this.HOI4_add_dlc_button.Text = "Enable selected DLC";
            this.HOI4_add_dlc_button.UseVisualStyleBackColor = true;
            this.HOI4_add_dlc_button.Click += new System.EventHandler(this.HOI4_add_dlc_button_Click);
            // 
            // hoi4_enabled_dlc_listbox
            // 
            this.hoi4_enabled_dlc_listbox.FormattingEnabled = true;
            this.hoi4_enabled_dlc_listbox.Location = new System.Drawing.Point(9, 163);
            this.hoi4_enabled_dlc_listbox.Name = "hoi4_enabled_dlc_listbox";
            this.hoi4_enabled_dlc_listbox.Size = new System.Drawing.Size(207, 95);
            this.hoi4_enabled_dlc_listbox.TabIndex = 12;
            // 
            // HOI4_all_dlc_listbox
            // 
            this.HOI4_all_dlc_listbox.FormattingEnabled = true;
            this.HOI4_all_dlc_listbox.Location = new System.Drawing.Point(8, 27);
            this.HOI4_all_dlc_listbox.Name = "HOI4_all_dlc_listbox";
            this.HOI4_all_dlc_listbox.Size = new System.Drawing.Size(208, 95);
            this.HOI4_all_dlc_listbox.TabIndex = 11;
            // 
            // HOI4_playset_selector_panel
            // 
            this.HOI4_playset_selector_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HOI4_playset_selector_panel.Controls.Add(this.playset_name_textbox);
            this.HOI4_playset_selector_panel.Controls.Add(this.HOI4_playset_lisbox);
            this.HOI4_playset_selector_panel.Controls.Add(this.load_playset_button);
            this.HOI4_playset_selector_panel.Controls.Add(this.create_new_playset_button);
            this.HOI4_playset_selector_panel.Location = new System.Drawing.Point(784, 8);
            this.HOI4_playset_selector_panel.Name = "HOI4_playset_selector_panel";
            this.HOI4_playset_selector_panel.Size = new System.Drawing.Size(320, 299);
            this.HOI4_playset_selector_panel.TabIndex = 6;
            // 
            // playset_name_textbox
            // 
            this.playset_name_textbox.Location = new System.Drawing.Point(192, 8);
            this.playset_name_textbox.Multiline = true;
            this.playset_name_textbox.Name = "playset_name_textbox";
            this.playset_name_textbox.Size = new System.Drawing.Size(118, 39);
            this.playset_name_textbox.TabIndex = 4;
            this.playset_name_textbox.Text = "Playset name";
            // 
            // HOI4_playset_lisbox
            // 
            this.HOI4_playset_lisbox.FormattingEnabled = true;
            this.HOI4_playset_lisbox.Location = new System.Drawing.Point(8, 8);
            this.HOI4_playset_lisbox.Name = "HOI4_playset_lisbox";
            this.HOI4_playset_lisbox.Size = new System.Drawing.Size(176, 277);
            this.HOI4_playset_lisbox.TabIndex = 3;
            // 
            // load_playset_button
            // 
            this.load_playset_button.Location = new System.Drawing.Point(192, 80);
            this.load_playset_button.Name = "load_playset_button";
            this.load_playset_button.Size = new System.Drawing.Size(118, 21);
            this.load_playset_button.TabIndex = 2;
            this.load_playset_button.Text = "Load selected playset";
            this.load_playset_button.UseVisualStyleBackColor = true;
            this.load_playset_button.Click += new System.EventHandler(this.load_playset_button_Click);
            // 
            // create_new_playset_button
            // 
            this.create_new_playset_button.Location = new System.Drawing.Point(192, 53);
            this.create_new_playset_button.Name = "create_new_playset_button";
            this.create_new_playset_button.Size = new System.Drawing.Size(118, 21);
            this.create_new_playset_button.TabIndex = 1;
            this.create_new_playset_button.Text = "Create new playset";
            this.create_new_playset_button.UseVisualStyleBackColor = true;
            this.create_new_playset_button.Click += new System.EventHandler(this.create_new_playset_button_Click);
            // 
            // modding_panel
            // 
            this.modding_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modding_panel.Controls.Add(this.reload_workshop_mods_button);
            this.modding_panel.Controls.Add(this.new_mod_name_textbox);
            this.modding_panel.Controls.Add(this.create_new_mod_button);
            this.modding_panel.Location = new System.Drawing.Point(464, 312);
            this.modding_panel.Name = "modding_panel";
            this.modding_panel.Size = new System.Drawing.Size(311, 104);
            this.modding_panel.TabIndex = 5;
            // 
            // reload_workshop_mods_button
            // 
            this.reload_workshop_mods_button.Location = new System.Drawing.Point(8, 56);
            this.reload_workshop_mods_button.Name = "reload_workshop_mods_button";
            this.reload_workshop_mods_button.Size = new System.Drawing.Size(96, 40);
            this.reload_workshop_mods_button.TabIndex = 7;
            this.reload_workshop_mods_button.Text = "Reload workshop mods";
            this.reload_workshop_mods_button.UseVisualStyleBackColor = true;
            this.reload_workshop_mods_button.Click += new System.EventHandler(this.reload_workshop_mods_button_Click);
            // 
            // new_mod_name_textbox
            // 
            this.new_mod_name_textbox.Location = new System.Drawing.Point(112, 16);
            this.new_mod_name_textbox.Name = "new_mod_name_textbox";
            this.new_mod_name_textbox.Size = new System.Drawing.Size(184, 20);
            this.new_mod_name_textbox.TabIndex = 1;
            // 
            // create_new_mod_button
            // 
            this.create_new_mod_button.Location = new System.Drawing.Point(8, 8);
            this.create_new_mod_button.Name = "create_new_mod_button";
            this.create_new_mod_button.Size = new System.Drawing.Size(96, 40);
            this.create_new_mod_button.TabIndex = 0;
            this.create_new_mod_button.Text = "Create my new mod";
            this.create_new_mod_button.UseVisualStyleBackColor = true;
            this.create_new_mod_button.Click += new System.EventHandler(this.create_new_mod_button_Click);
            // 
            // cmdArgs_textbox
            // 
            this.cmdArgs_textbox.Location = new System.Drawing.Point(8, 40);
            this.cmdArgs_textbox.Multiline = true;
            this.cmdArgs_textbox.Name = "cmdArgs_textbox";
            this.cmdArgs_textbox.Size = new System.Drawing.Size(200, 56);
            this.cmdArgs_textbox.TabIndex = 6;
            this.cmdArgs_textbox.Text = "Command line arguments (seperate by newline)";
            this.cmdArgs_textbox.TextChanged += new System.EventHandler(this.cmdArgs_textbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 431);
            this.Controls.Add(this.modding_panel);
            this.Controls.Add(this.HOI4_playset_selector_panel);
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
            this.launch_panel.PerformLayout();
            this.HOI4_dlc_selection_panel.ResumeLayout(false);
            this.HOI4_dlc_selection_panel.PerformLayout();
            this.HOI4_playset_selector_panel.ResumeLayout(false);
            this.HOI4_playset_selector_panel.PerformLayout();
            this.modding_panel.ResumeLayout(false);
            this.modding_panel.PerformLayout();
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
        private System.Windows.Forms.ListBox enabled_mods_listbox;
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
        private System.Windows.Forms.Panel HOI4_playset_selector_panel;
        private System.Windows.Forms.Button load_playset_button;
        private System.Windows.Forms.Button create_new_playset_button;
        private System.Windows.Forms.ListBox HOI4_playset_lisbox;
        private System.Windows.Forms.TextBox playset_name_textbox;
        private System.Windows.Forms.Panel modding_panel;
        private System.Windows.Forms.Button create_new_mod_button;
        private System.Windows.Forms.TextBox new_mod_name_textbox;
        private System.Windows.Forms.Button reload_workshop_mods_button;
        private System.Windows.Forms.Button workshop_folder_button;
        private System.Windows.Forms.TextBox workshop_folder_textbox;
        private System.Windows.Forms.TextBox cmdArgs_textbox;
    }
}

