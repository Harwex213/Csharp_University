﻿
namespace S2_Lab02
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AirYearReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AirYearReleaseLabel = new System.Windows.Forms.Label();
            this.AirTypeCargo = new System.Windows.Forms.RadioButton();
            this.AirTypePassenger = new System.Windows.Forms.RadioButton();
            this.AirTypeMilitary = new System.Windows.Forms.RadioButton();
            this.AirModelList = new System.Windows.Forms.ComboBox();
            this.AirModelLabel = new System.Windows.Forms.Label();
            this.AirTypeGroup = new System.Windows.Forms.GroupBox();
            this.AirLoadCapacitySetter = new System.Windows.Forms.NumericUpDown();
            this.AirLoadCapacityLabel = new System.Windows.Forms.Label();
            this.AirTechServiceDatePicker = new System.Windows.Forms.MonthCalendar();
            this.AirTechServiceLabel = new System.Windows.Forms.Label();
            this.AirAddGroup = new System.Windows.Forms.GroupBox();
            this.AirPassengersSeatsLabel = new System.Windows.Forms.Label();
            this.AirPassengersSeatsSetter = new System.Windows.Forms.NumericUpDown();
            this.AirIdLabel = new System.Windows.Forms.Label();
            this.CrewAddGroup = new System.Windows.Forms.GroupBox();
            this.CrewMemberPositionList = new System.Windows.Forms.ComboBox();
            this.CrewMemberWorkExperienceLabel = new System.Windows.Forms.Label();
            this.CrewMemberPositionLabel = new System.Windows.Forms.Label();
            this.CrewMemberWorkExperienceSetter = new System.Windows.Forms.NumericUpDown();
            this.CrewMemberAgeLabel = new System.Windows.Forms.Label();
            this.CrewMemberAgeSetter = new System.Windows.Forms.NumericUpDown();
            this.CrewMemberPatronymicLabel = new System.Windows.Forms.Label();
            this.CrewMemberPatronymicInput = new System.Windows.Forms.TextBox();
            this.CrewMemberSurnameLabel = new System.Windows.Forms.Label();
            this.CrewMemberSurnameInput = new System.Windows.Forms.TextBox();
            this.CrewMemberNameLabel = new System.Windows.Forms.Label();
            this.CrewMemberNameInput = new System.Windows.Forms.TextBox();
            this.CrewMemberIdLabel = new System.Windows.Forms.Label();
            this.CrewMemberAddButton = new System.Windows.Forms.Button();
            this.DataReadButton = new System.Windows.Forms.Button();
            this.DataSaveButton = new System.Windows.Forms.Button();
            this.AirAddButton = new System.Windows.Forms.Button();
            this.DataGroup = new System.Windows.Forms.GroupBox();
            this.AirTypeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.AirLoadCapacitySetter)).BeginInit();
            this.AirAddGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.AirPassengersSeatsSetter)).BeginInit();
            this.CrewAddGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CrewMemberWorkExperienceSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.CrewMemberAgeSetter)).BeginInit();
            this.DataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AirYearReleaseDatePicker
            // 
            this.AirYearReleaseDatePicker.Location = new System.Drawing.Point(6, 232);
            this.AirYearReleaseDatePicker.Name = "AirYearReleaseDatePicker";
            this.AirYearReleaseDatePicker.Size = new System.Drawing.Size(261, 22);
            this.AirYearReleaseDatePicker.TabIndex = 2;
            // 
            // AirYearReleaseLabel
            // 
            this.AirYearReleaseLabel.Location = new System.Drawing.Point(6, 210);
            this.AirYearReleaseLabel.Name = "AirYearReleaseLabel";
            this.AirYearReleaseLabel.Size = new System.Drawing.Size(100, 19);
            this.AirYearReleaseLabel.TabIndex = 3;
            this.AirYearReleaseLabel.Text = "Год выпуска";
            // 
            // AirTypeCargo
            // 
            this.AirTypeCargo.Location = new System.Drawing.Point(6, 19);
            this.AirTypeCargo.Name = "AirTypeCargo";
            this.AirTypeCargo.Size = new System.Drawing.Size(104, 24);
            this.AirTypeCargo.TabIndex = 5;
            this.AirTypeCargo.TabStop = true;
            this.AirTypeCargo.Text = "Грузовой";
            this.AirTypeCargo.UseVisualStyleBackColor = true;
            // 
            // AirTypePassenger
            // 
            this.AirTypePassenger.Location = new System.Drawing.Point(6, 49);
            this.AirTypePassenger.Name = "AirTypePassenger";
            this.AirTypePassenger.Size = new System.Drawing.Size(207, 24);
            this.AirTypePassenger.TabIndex = 6;
            this.AirTypePassenger.TabStop = true;
            this.AirTypePassenger.Text = "Пассажирский";
            this.AirTypePassenger.UseVisualStyleBackColor = true;
            // 
            // AirTypeMilitary
            // 
            this.AirTypeMilitary.Location = new System.Drawing.Point(6, 79);
            this.AirTypeMilitary.Name = "AirTypeMilitary";
            this.AirTypeMilitary.Size = new System.Drawing.Size(104, 24);
            this.AirTypeMilitary.TabIndex = 7;
            this.AirTypeMilitary.TabStop = true;
            this.AirTypeMilitary.Text = "Военный";
            this.AirTypeMilitary.UseVisualStyleBackColor = true;
            // 
            // AirModelList
            // 
            this.AirModelList.FormattingEnabled = true;
            this.AirModelList.Location = new System.Drawing.Point(6, 183);
            this.AirModelList.Name = "AirModelList";
            this.AirModelList.Size = new System.Drawing.Size(261, 24);
            this.AirModelList.TabIndex = 8;
            // 
            // AirModelLabel
            // 
            this.AirModelLabel.Location = new System.Drawing.Point(6, 162);
            this.AirModelLabel.Name = "AirModelLabel";
            this.AirModelLabel.Size = new System.Drawing.Size(164, 14);
            this.AirModelLabel.TabIndex = 9;
            this.AirModelLabel.Text = "Модель самолёта";
            // 
            // AirTypeGroup
            // 
            this.AirTypeGroup.Controls.Add(this.AirTypeCargo);
            this.AirTypeGroup.Controls.Add(this.AirTypePassenger);
            this.AirTypeGroup.Controls.Add(this.AirTypeMilitary);
            this.AirTypeGroup.Location = new System.Drawing.Point(6, 53);
            this.AirTypeGroup.Name = "AirTypeGroup";
            this.AirTypeGroup.Size = new System.Drawing.Size(261, 106);
            this.AirTypeGroup.TabIndex = 10;
            this.AirTypeGroup.TabStop = false;
            this.AirTypeGroup.Text = "Тип самолёта";
            // 
            // AirLoadCapacitySetter
            // 
            this.AirLoadCapacitySetter.Increment = new decimal(new int[] {5, 0, 0, 0});
            this.AirLoadCapacitySetter.Location = new System.Drawing.Point(6, 523);
            this.AirLoadCapacitySetter.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.AirLoadCapacitySetter.Minimum = new decimal(new int[] {10, 0, 0, 0});
            this.AirLoadCapacitySetter.Name = "AirLoadCapacitySetter";
            this.AirLoadCapacitySetter.Size = new System.Drawing.Size(120, 22);
            this.AirLoadCapacitySetter.TabIndex = 11;
            this.AirLoadCapacitySetter.Value = new decimal(new int[] {10, 0, 0, 0});
            // 
            // AirLoadCapacityLabel
            // 
            this.AirLoadCapacityLabel.Location = new System.Drawing.Point(6, 501);
            this.AirLoadCapacityLabel.Name = "AirLoadCapacityLabel";
            this.AirLoadCapacityLabel.Size = new System.Drawing.Size(261, 19);
            this.AirLoadCapacityLabel.TabIndex = 12;
            this.AirLoadCapacityLabel.Text = "Грузоподъёмность (тонн)";
            // 
            // AirTechServiceDatePicker
            // 
            this.AirTechServiceDatePicker.Location = new System.Drawing.Point(6, 285);
            this.AirTechServiceDatePicker.Name = "AirTechServiceDatePicker";
            this.AirTechServiceDatePicker.TabIndex = 13;
            // 
            // AirTechServiceLabel
            // 
            this.AirTechServiceLabel.Location = new System.Drawing.Point(6, 257);
            this.AirTechServiceLabel.Name = "AirTechServiceLabel";
            this.AirTechServiceLabel.Size = new System.Drawing.Size(261, 19);
            this.AirTechServiceLabel.TabIndex = 14;
            this.AirTechServiceLabel.Text = "Год последнего тех. обслуживания";
            // 
            // AirAddGroup
            // 
            this.AirAddGroup.Controls.Add(this.AirPassengersSeatsLabel);
            this.AirAddGroup.Controls.Add(this.AirPassengersSeatsSetter);
            this.AirAddGroup.Controls.Add(this.AirIdLabel);
            this.AirAddGroup.Controls.Add(this.AirTypeGroup);
            this.AirAddGroup.Controls.Add(this.AirTechServiceLabel);
            this.AirAddGroup.Controls.Add(this.AirYearReleaseDatePicker);
            this.AirAddGroup.Controls.Add(this.AirTechServiceDatePicker);
            this.AirAddGroup.Controls.Add(this.AirYearReleaseLabel);
            this.AirAddGroup.Controls.Add(this.AirLoadCapacityLabel);
            this.AirAddGroup.Controls.Add(this.AirModelList);
            this.AirAddGroup.Controls.Add(this.AirLoadCapacitySetter);
            this.AirAddGroup.Controls.Add(this.AirModelLabel);
            this.AirAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AirAddGroup.Location = new System.Drawing.Point(12, 12);
            this.AirAddGroup.Name = "AirAddGroup";
            this.AirAddGroup.Size = new System.Drawing.Size(275, 600);
            this.AirAddGroup.TabIndex = 15;
            this.AirAddGroup.TabStop = false;
            this.AirAddGroup.Text = "Добавление Самолёта";
            // 
            // AirPassengersSeatsLabel
            // 
            this.AirPassengersSeatsLabel.Location = new System.Drawing.Point(6, 548);
            this.AirPassengersSeatsLabel.Name = "AirPassengersSeatsLabel";
            this.AirPassengersSeatsLabel.Size = new System.Drawing.Size(261, 19);
            this.AirPassengersSeatsLabel.TabIndex = 17;
            this.AirPassengersSeatsLabel.Text = "Количество пассажирских мест";
            // 
            // AirPassengersSeatsSetter
            // 
            this.AirPassengersSeatsSetter.Location = new System.Drawing.Point(6, 570);
            this.AirPassengersSeatsSetter.Maximum = new decimal(new int[] {300, 0, 0, 0});
            this.AirPassengersSeatsSetter.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.AirPassengersSeatsSetter.Name = "AirPassengersSeatsSetter";
            this.AirPassengersSeatsSetter.Size = new System.Drawing.Size(120, 22);
            this.AirPassengersSeatsSetter.TabIndex = 16;
            this.AirPassengersSeatsSetter.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // AirIdLabel
            // 
            this.AirIdLabel.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AirIdLabel.Location = new System.Drawing.Point(6, 18);
            this.AirIdLabel.Name = "AirIdLabel";
            this.AirIdLabel.Size = new System.Drawing.Size(156, 32);
            this.AirIdLabel.TabIndex = 15;
            this.AirIdLabel.Text = "Air ID: 0";
            // 
            // CrewAddGroup
            // 
            this.CrewAddGroup.Controls.Add(this.CrewMemberPositionList);
            this.CrewAddGroup.Controls.Add(this.CrewMemberWorkExperienceLabel);
            this.CrewAddGroup.Controls.Add(this.CrewMemberPositionLabel);
            this.CrewAddGroup.Controls.Add(this.CrewMemberWorkExperienceSetter);
            this.CrewAddGroup.Controls.Add(this.CrewMemberAgeLabel);
            this.CrewAddGroup.Controls.Add(this.CrewMemberAgeSetter);
            this.CrewAddGroup.Controls.Add(this.CrewMemberPatronymicLabel);
            this.CrewAddGroup.Controls.Add(this.CrewMemberPatronymicInput);
            this.CrewAddGroup.Controls.Add(this.CrewMemberSurnameLabel);
            this.CrewAddGroup.Controls.Add(this.CrewMemberSurnameInput);
            this.CrewAddGroup.Controls.Add(this.CrewMemberNameLabel);
            this.CrewAddGroup.Controls.Add(this.CrewMemberNameInput);
            this.CrewAddGroup.Controls.Add(this.CrewMemberIdLabel);
            this.CrewAddGroup.Location = new System.Drawing.Point(293, 12);
            this.CrewAddGroup.Name = "CrewAddGroup";
            this.CrewAddGroup.Size = new System.Drawing.Size(378, 322);
            this.CrewAddGroup.TabIndex = 16;
            this.CrewAddGroup.TabStop = false;
            this.CrewAddGroup.Text = "Добавление экипажа";
            // 
            // CrewMemberPositionList
            // 
            this.CrewMemberPositionList.FormattingEnabled = true;
            this.CrewMemberPositionList.Location = new System.Drawing.Point(6, 291);
            this.CrewMemberPositionList.Name = "CrewMemberPositionList";
            this.CrewMemberPositionList.Size = new System.Drawing.Size(261, 24);
            this.CrewMemberPositionList.TabIndex = 18;
            // 
            // CrewMemberWorkExperienceLabel
            // 
            this.CrewMemberWorkExperienceLabel.Location = new System.Drawing.Point(6, 223);
            this.CrewMemberWorkExperienceLabel.Name = "CrewMemberWorkExperienceLabel";
            this.CrewMemberWorkExperienceLabel.Size = new System.Drawing.Size(261, 19);
            this.CrewMemberWorkExperienceLabel.TabIndex = 25;
            this.CrewMemberWorkExperienceLabel.Text = "Стаж работы";
            // 
            // CrewMemberPositionLabel
            // 
            this.CrewMemberPositionLabel.Location = new System.Drawing.Point(6, 270);
            this.CrewMemberPositionLabel.Name = "CrewMemberPositionLabel";
            this.CrewMemberPositionLabel.Size = new System.Drawing.Size(164, 14);
            this.CrewMemberPositionLabel.TabIndex = 19;
            this.CrewMemberPositionLabel.Text = "Должность";
            // 
            // CrewMemberWorkExperienceSetter
            // 
            this.CrewMemberWorkExperienceSetter.Increment = new decimal(new int[] {5, 0, 0, 0});
            this.CrewMemberWorkExperienceSetter.Location = new System.Drawing.Point(6, 245);
            this.CrewMemberWorkExperienceSetter.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.CrewMemberWorkExperienceSetter.Minimum = new decimal(new int[] {10, 0, 0, 0});
            this.CrewMemberWorkExperienceSetter.Name = "CrewMemberWorkExperienceSetter";
            this.CrewMemberWorkExperienceSetter.Size = new System.Drawing.Size(120, 22);
            this.CrewMemberWorkExperienceSetter.TabIndex = 24;
            this.CrewMemberWorkExperienceSetter.Value = new decimal(new int[] {10, 0, 0, 0});
            // 
            // CrewMemberAgeLabel
            // 
            this.CrewMemberAgeLabel.Location = new System.Drawing.Point(6, 176);
            this.CrewMemberAgeLabel.Name = "CrewMemberAgeLabel";
            this.CrewMemberAgeLabel.Size = new System.Drawing.Size(261, 19);
            this.CrewMemberAgeLabel.TabIndex = 19;
            this.CrewMemberAgeLabel.Text = "Возраст";
            // 
            // CrewMemberAgeSetter
            // 
            this.CrewMemberAgeSetter.Location = new System.Drawing.Point(6, 198);
            this.CrewMemberAgeSetter.Maximum = new decimal(new int[] {45, 0, 0, 0});
            this.CrewMemberAgeSetter.Minimum = new decimal(new int[] {18, 0, 0, 0});
            this.CrewMemberAgeSetter.Name = "CrewMemberAgeSetter";
            this.CrewMemberAgeSetter.Size = new System.Drawing.Size(120, 22);
            this.CrewMemberAgeSetter.TabIndex = 18;
            this.CrewMemberAgeSetter.Value = new decimal(new int[] {18, 0, 0, 0});
            // 
            // CrewMemberPatronymicLabel
            // 
            this.CrewMemberPatronymicLabel.Location = new System.Drawing.Point(6, 134);
            this.CrewMemberPatronymicLabel.Name = "CrewMemberPatronymicLabel";
            this.CrewMemberPatronymicLabel.Size = new System.Drawing.Size(164, 14);
            this.CrewMemberPatronymicLabel.TabIndex = 22;
            this.CrewMemberPatronymicLabel.Text = "Отчество";
            // 
            // CrewMemberPatronymicInput
            // 
            this.CrewMemberPatronymicInput.Location = new System.Drawing.Point(6, 151);
            this.CrewMemberPatronymicInput.Name = "CrewMemberPatronymicInput";
            this.CrewMemberPatronymicInput.Size = new System.Drawing.Size(147, 22);
            this.CrewMemberPatronymicInput.TabIndex = 23;
            // 
            // CrewMemberSurnameLabel
            // 
            this.CrewMemberSurnameLabel.Location = new System.Drawing.Point(6, 92);
            this.CrewMemberSurnameLabel.Name = "CrewMemberSurnameLabel";
            this.CrewMemberSurnameLabel.Size = new System.Drawing.Size(164, 14);
            this.CrewMemberSurnameLabel.TabIndex = 20;
            this.CrewMemberSurnameLabel.Text = "Фамилия";
            // 
            // CrewMemberSurnameInput
            // 
            this.CrewMemberSurnameInput.Location = new System.Drawing.Point(6, 109);
            this.CrewMemberSurnameInput.Name = "CrewMemberSurnameInput";
            this.CrewMemberSurnameInput.Size = new System.Drawing.Size(147, 22);
            this.CrewMemberSurnameInput.TabIndex = 21;
            // 
            // CrewMemberNameLabel
            // 
            this.CrewMemberNameLabel.Location = new System.Drawing.Point(6, 50);
            this.CrewMemberNameLabel.Name = "CrewMemberNameLabel";
            this.CrewMemberNameLabel.Size = new System.Drawing.Size(164, 14);
            this.CrewMemberNameLabel.TabIndex = 18;
            this.CrewMemberNameLabel.Text = "Имя";
            // 
            // CrewMemberNameInput
            // 
            this.CrewMemberNameInput.Location = new System.Drawing.Point(6, 67);
            this.CrewMemberNameInput.Name = "CrewMemberNameInput";
            this.CrewMemberNameInput.Size = new System.Drawing.Size(147, 22);
            this.CrewMemberNameInput.TabIndex = 19;
            // 
            // CrewMemberIdLabel
            // 
            this.CrewMemberIdLabel.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CrewMemberIdLabel.Location = new System.Drawing.Point(6, 18);
            this.CrewMemberIdLabel.Name = "CrewMemberIdLabel";
            this.CrewMemberIdLabel.Size = new System.Drawing.Size(363, 32);
            this.CrewMemberIdLabel.TabIndex = 18;
            this.CrewMemberIdLabel.Text = "Член экипажа номер: 1";
            // 
            // CrewMemberAddButton
            // 
            this.CrewMemberAddButton.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CrewMemberAddButton.Location = new System.Drawing.Point(293, 340);
            this.CrewMemberAddButton.Name = "CrewMemberAddButton";
            this.CrewMemberAddButton.Size = new System.Drawing.Size(378, 56);
            this.CrewMemberAddButton.TabIndex = 17;
            this.CrewMemberAddButton.Text = "Добавить члена экипажа";
            this.CrewMemberAddButton.UseVisualStyleBackColor = true;
            // 
            // DataReadButton
            // 
            this.DataReadButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.DataReadButton.Location = new System.Drawing.Point(187, 21);
            this.DataReadButton.Name = "DataReadButton";
            this.DataReadButton.Size = new System.Drawing.Size(182, 70);
            this.DataReadButton.TabIndex = 18;
            this.DataReadButton.Text = "Считать данные";
            this.DataReadButton.UseVisualStyleBackColor = true;
            // 
            // DataSaveButton
            // 
            this.DataSaveButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.DataSaveButton.Location = new System.Drawing.Point(6, 21);
            this.DataSaveButton.Name = "DataSaveButton";
            this.DataSaveButton.Size = new System.Drawing.Size(180, 70);
            this.DataSaveButton.TabIndex = 19;
            this.DataSaveButton.Text = "Сохранить данные";
            this.DataSaveButton.UseVisualStyleBackColor = true;
            // 
            // AirAddButton
            // 
            this.AirAddButton.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AirAddButton.Location = new System.Drawing.Point(293, 510);
            this.AirAddButton.Name = "AirAddButton";
            this.AirAddButton.Size = new System.Drawing.Size(378, 102);
            this.AirAddButton.TabIndex = 20;
            this.AirAddButton.Text = "Добавить самолёт";
            this.AirAddButton.UseVisualStyleBackColor = true;
            // 
            // DataGroup
            // 
            this.DataGroup.Controls.Add(this.DataReadButton);
            this.DataGroup.Controls.Add(this.DataSaveButton);
            this.DataGroup.Location = new System.Drawing.Point(293, 403);
            this.DataGroup.Name = "DataGroup";
            this.DataGroup.Size = new System.Drawing.Size(378, 101);
            this.DataGroup.TabIndex = 21;
            this.DataGroup.TabStop = false;
            this.DataGroup.Text = "Данные";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 621);
            this.Controls.Add(this.DataGroup);
            this.Controls.Add(this.AirAddButton);
            this.Controls.Add(this.CrewMemberAddButton);
            this.Controls.Add(this.CrewAddGroup);
            this.Controls.Add(this.AirAddGroup);
            this.MaximumSize = new System.Drawing.Size(701, 668);
            this.MinimumSize = new System.Drawing.Size(701, 668);
            this.Name = "Form1";
            this.Text = "Form Input";
            this.AirTypeGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.AirLoadCapacitySetter)).EndInit();
            this.AirAddGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.AirPassengersSeatsSetter)).EndInit();
            this.CrewAddGroup.ResumeLayout(false);
            this.CrewAddGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CrewMemberWorkExperienceSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.CrewMemberAgeSetter)).EndInit();
            this.DataGroup.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox DataGroup;

        private System.Windows.Forms.Button CrewMemberAddButton;
        private System.Windows.Forms.Button DataReadButton;
        private System.Windows.Forms.Button DataSaveButton;
        private System.Windows.Forms.Button AirAddButton;

        private System.Windows.Forms.ComboBox CrewMemberPositionList;
        private System.Windows.Forms.Label CrewMemberPositionLabel;

        private System.Windows.Forms.Label CrewMemberWorkExperienceLabel;
        private System.Windows.Forms.NumericUpDown CrewMemberWorkExperienceSetter;

        private System.Windows.Forms.Label CrewMemberAgeLabel;
        private System.Windows.Forms.NumericUpDown CrewMemberAgeSetter;

        private System.Windows.Forms.Label CrewMemberNameLabel;
        private System.Windows.Forms.Label CrewMemberSurnameLabel;
        private System.Windows.Forms.Label CrewMemberPatronymicLabel;
        private System.Windows.Forms.TextBox CrewMemberSurnameInput;
        private System.Windows.Forms.TextBox CrewMemberPatronymicInput;

        private System.Windows.Forms.TextBox CrewMemberNameInput;

        private System.Windows.Forms.Label CrewMemberIdLabel;

        private System.Windows.Forms.GroupBox CrewAddGroup;

        private System.Windows.Forms.Label AirPassengersSeatsLabel;
        private System.Windows.Forms.NumericUpDown AirPassengersSeatsSetter;

        private System.Windows.Forms.Label AirIdLabel;

        private System.Windows.Forms.GroupBox AirAddGroup;
        private System.Windows.Forms.Label AirTechServiceLabel;
        private System.Windows.Forms.MonthCalendar AirTechServiceDatePicker;

        private System.Windows.Forms.Label AirLoadCapacityLabel;
        private System.Windows.Forms.NumericUpDown AirLoadCapacitySetter;

        private System.Windows.Forms.GroupBox AirTypeGroup;

        private System.Windows.Forms.ComboBox AirModelList;
        private System.Windows.Forms.Label AirModelLabel;

        private System.Windows.Forms.RadioButton AirTypeMilitary;

        private System.Windows.Forms.RadioButton AirTypeCargo;
        private System.Windows.Forms.RadioButton AirTypePassenger;

        private System.Windows.Forms.DateTimePicker AirYearReleaseDatePicker;
        private System.Windows.Forms.Label AirYearReleaseLabel;

        #endregion
    }
}

