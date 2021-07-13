﻿Imports System.ComponentModel
Imports MetroFramework
Imports MetroFramework.Components
Imports MetroFramework.Controls
Imports MetroFramework.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports MLBGames.My.Resources

<DesignerGenerated()>
Partial Class MLBGamesMetro
    Inherits MetroForm

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MLBGamesMetro))
        Me.txtConsole = New System.Windows.Forms.RichTextBox()
        Me.tabMenu = New MetroFramework.Controls.MetroTabControl()
        Me.tabGames = New MetroFramework.Controls.MetroTabPage()
        Me.spnLoading = New MetroFramework.Controls.MetroProgressSpinner()
        Me.lblDate = New MetroFramework.Controls.MetroLabel()
        Me.lblNoGames = New System.Windows.Forms.Label()
        Me.flpCalendarPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpGames = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlGameBar = New MetroFramework.Controls.MetroPanel()
        Me.btnTomorrow = New System.Windows.Forms.Button()
        Me.btnYesterday = New System.Windows.Forms.Button()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.tabStandings = New MetroFramework.Controls.MetroTabPage()
        Me.tlpStandings = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSeason = New MetroFramework.Controls.MetroLabel()
        Me.tbStanding = New MetroFramework.Controls.MetroTabControl()
        Me.tabSettings = New MetroFramework.Controls.MetroTabPage()
        Me.tlpSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpOBSSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.lblObsAdEndingHotkey = New MetroFramework.Controls.MetroLabel()
        Me.lblObsAdStartingHotkey = New MetroFramework.Controls.MetroLabel()
        Me.flpGameSceneHotkey = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtGameKey = New MetroFramework.Controls.MetroTextBox()
        Me.lblPlus1 = New MetroFramework.Controls.MetroLabel()
        Me.chkGameCtrl = New MetroFramework.Controls.MetroCheckBox()
        Me.lblPlus2 = New MetroFramework.Controls.MetroLabel()
        Me.chkGameAlt = New MetroFramework.Controls.MetroCheckBox()
        Me.lblPlus3 = New MetroFramework.Controls.MetroLabel()
        Me.chkGameShift = New MetroFramework.Controls.MetroCheckBox()
        Me.flpAdSceneHotkey = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtAdKey = New MetroFramework.Controls.MetroTextBox()
        Me.lblPlus4 = New MetroFramework.Controls.MetroLabel()
        Me.chkAdCtrl = New MetroFramework.Controls.MetroCheckBox()
        Me.lblPlus5 = New MetroFramework.Controls.MetroLabel()
        Me.chkAdAlt = New MetroFramework.Controls.MetroCheckBox()
        Me.lblPlus6 = New MetroFramework.Controls.MetroLabel()
        Me.chkAdShift = New MetroFramework.Controls.MetroCheckBox()
        Me.flpObsDescSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgOBS = New MetroFramework.Controls.MetroToggle()
        Me.lblOBSDesc = New MetroFramework.Controls.MetroLabel()
        Me.flpSpotifyDescSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgMedia = New MetroFramework.Controls.MetroToggle()
        Me.lblMediaDesc = New MetroFramework.Controls.MetroLabel()
        Me.lblStreamerArgs = New MetroFramework.Controls.MetroLabel()
        Me.lblPlayerArgs = New MetroFramework.Controls.MetroLabel()
        Me.lblOutput = New MetroFramework.Controls.MetroLabel()
        Me.flpStreamerArgs = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgStreamer = New MetroFramework.Controls.MetroToggle()
        Me.txtStreamerArgs = New System.Windows.Forms.TextBox()
        Me.flpPlayerArgs = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgPlayer = New MetroFramework.Controls.MetroToggle()
        Me.txtPlayerArgs = New System.Windows.Forms.TextBox()
        Me.flpOutputSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgOutput = New MetroFramework.Controls.MetroToggle()
        Me.txtOutputArgs = New System.Windows.Forms.TextBox()
        Me.btnOutput = New MetroFramework.Controls.MetroButton()
        Me.flpStreamerPath = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtStreamerPath = New System.Windows.Forms.TextBox()
        Me.btnStreamerPath = New MetroFramework.Controls.MetroButton()
        Me.flpMpvPath = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtMpvPath = New System.Windows.Forms.TextBox()
        Me.btnMpvPath = New MetroFramework.Controls.MetroButton()
        Me.flpMpcPath = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtMPCPath = New System.Windows.Forms.TextBox()
        Me.btnMPCPath = New MetroFramework.Controls.MetroButton()
        Me.lnkGetMpc = New MetroFramework.Controls.MetroLink()
        Me.flpVlcPath = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtVLCPath = New System.Windows.Forms.TextBox()
        Me.btnVLCPath = New MetroFramework.Controls.MetroButton()
        Me.lnkGetVlc = New MetroFramework.Controls.MetroLink()
        Me.lblLanguage = New MetroFramework.Controls.MetroLabel()
        Me.flpLanguage = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblSlPath = New MetroFramework.Controls.MetroLabel()
        Me.lblMpvPath = New MetroFramework.Controls.MetroLabel()
        Me.lblMpcPath = New MetroFramework.Controls.MetroLabel()
        Me.lblVlcPath = New MetroFramework.Controls.MetroLabel()
        Me.lblHostname = New MetroFramework.Controls.MetroLabel()
        Me.lblQuality = New MetroFramework.Controls.MetroLabel()
        Me.lblGamePanel = New MetroFramework.Controls.MetroLabel()
        Me.lblProxyPort = New MetroFramework.Controls.MetroLabel()
        Me.flpHostsFile = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblProxyPortNumber = New MetroFramework.Controls.MetroLabel()
        Me.tlpGamePanelSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.tgShowStanding = New MetroFramework.Controls.MetroToggle()
        Me.tgShowTodayLiveGamesFirst = New MetroFramework.Controls.MetroToggle()
        Me.lblShowTodayLiveGamesFirst = New MetroFramework.Controls.MetroLabel()
        Me.lblShowTeamCityAbr = New MetroFramework.Controls.MetroLabel()
        Me.tgShowTeamCityAbr = New MetroFramework.Controls.MetroToggle()
        Me.lblShowLiveScores = New MetroFramework.Controls.MetroLabel()
        Me.tgShowLiveScores = New MetroFramework.Controls.MetroToggle()
        Me.lblShowSeriesRecord = New MetroFramework.Controls.MetroLabel()
        Me.lblShowFinalScores = New MetroFramework.Controls.MetroLabel()
        Me.tgShowFinalScores = New MetroFramework.Controls.MetroToggle()
        Me.tgShowSeriesRecord = New MetroFramework.Controls.MetroToggle()
        Me.tgShowLiveTime = New MetroFramework.Controls.MetroToggle()
        Me.lblShowLiveTime = New MetroFramework.Controls.MetroLabel()
        Me.lblShowStanding = New MetroFramework.Controls.MetroLabel()
        Me.lblPlayer = New MetroFramework.Controls.MetroLabel()
        Me.flpSelectedPlayer = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbMPV = New MetroFramework.Controls.MetroRadioButton()
        Me.lblMPVLogo = New System.Windows.Forms.Label()
        Me.rbVLC = New MetroFramework.Controls.MetroRadioButton()
        Me.lblVLCLogo = New System.Windows.Forms.Label()
        Me.rbMPC = New MetroFramework.Controls.MetroRadioButton()
        Me.lvlMPCHCLogo = New System.Windows.Forms.Label()
        Me.tlpCdnSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.tgAlternateCdn = New MetroFramework.Controls.MetroToggle()
        Me.lblUseAlternateCdn = New MetroFramework.Controls.MetroLabel()
        Me.lblMedia = New MetroFramework.Controls.MetroLabel()
        Me.lblOBS = New MetroFramework.Controls.MetroLabel()
        Me.flpSpotifyParameters = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkSpotifyPlayNextSong = New MetroFramework.Controls.MetroCheckBox()
        Me.chkSpotifyHotkeys = New MetroFramework.Controls.MetroCheckBox()
        Me.chkSpotifyForceToStart = New MetroFramework.Controls.MetroCheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblMediaControlDelay = New MetroFramework.Controls.MetroLabel()
        Me.txtMediaControlDelay = New MetroFramework.Controls.MetroTextBox()
        Me.lblMediaControlDelayMs = New MetroFramework.Controls.MetroLabel()
        Me.lblModules = New MetroFramework.Controls.MetroLabel()
        Me.flpAdDetection = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgModules = New MetroFramework.Controls.MetroToggle()
        Me.lblModulesDesc = New MetroFramework.Controls.MetroLabel()
        Me.tlpReplay = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLiveRewindDetails = New MetroFramework.Controls.MetroLabel()
        Me.lblLiveRewind = New MetroFramework.Controls.MetroLabel()
        Me.lblCdn = New MetroFramework.Controls.MetroLabel()
        Me.lblLiveReplay = New MetroFramework.Controls.MetroLabel()
        Me.tgDarkMode = New MetroFramework.Controls.MetroToggle()
        Me.lblDarkMode = New MetroFramework.Controls.MetroLabel()
        Me.lblReset = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgReset = New MetroFramework.Controls.MetroToggle()
        Me.lblResetDesc = New MetroFramework.Controls.MetroLabel()
        Me.tabConsole = New MetroFramework.Controls.MetroTabPage()
        Me.btnCopyConsole = New MetroFramework.Controls.MetroButton()
        Me.btnClearConsole = New MetroFramework.Controls.MetroButton()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.tt = New MetroFramework.Components.MetroToolTip()
        Me.pnlBottom = New MetroFramework.Controls.MetroPanel()
        Me.tlpStatus = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatus = New MetroFramework.Controls.MetroLabel()
        Me.lblVersion = New MetroFramework.Controls.MetroLabel()
        Me.lnkReddit = New MetroFramework.Controls.MetroLink()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTip = New MetroFramework.Controls.MetroLabel()
        Me.lnkRelease = New MetroFramework.Controls.MetroLink()
        Me.spnStreaming = New MetroFramework.Controls.MetroProgressSpinner()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.btnHelp = New MetroFramework.Controls.MetroLink()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.cbSeasons = New MLBGames.Controls.MetroComboBoxNoMW()
        Me.cbStreamQuality = New MLBGames.Controls.MetroComboBoxNoMW()
        Me.cbLanguage = New MLBGames.Controls.MetroComboBoxNoMW()
        Me.cbServers = New MLBGames.Controls.MetroComboBoxNoMW()
        Me.tbProxyPort = New MLBGames.Controls.MetroTrackBarNoMW()
        Me.tbLiveRewind = New MLBGames.Controls.MetroTrackBarNoMW()
        Me.cbLiveReplay = New MLBGames.Controls.MetroComboBoxNoMW()
        Me.tabMenu.SuspendLayout()
        Me.tabGames.SuspendLayout()
        Me.pnlGameBar.SuspendLayout()
        Me.tabStandings.SuspendLayout()
        Me.tlpStandings.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.tlpSettings.SuspendLayout()
        Me.tlpOBSSettings.SuspendLayout()
        Me.flpGameSceneHotkey.SuspendLayout()
        Me.flpAdSceneHotkey.SuspendLayout()
        Me.flpObsDescSettings.SuspendLayout()
        Me.flpSpotifyDescSettings.SuspendLayout()
        Me.flpStreamerArgs.SuspendLayout()
        Me.flpPlayerArgs.SuspendLayout()
        Me.flpOutputSettings.SuspendLayout()
        Me.flpStreamerPath.SuspendLayout()
        Me.flpMpvPath.SuspendLayout()
        Me.flpMpcPath.SuspendLayout()
        Me.flpVlcPath.SuspendLayout()
        Me.flpLanguage.SuspendLayout()
        Me.flpHostsFile.SuspendLayout()
        Me.tlpGamePanelSettings.SuspendLayout()
        Me.flpSelectedPlayer.SuspendLayout()
        Me.tlpCdnSettings.SuspendLayout()
        Me.flpSpotifyParameters.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.flpAdDetection.SuspendLayout()
        Me.tlpReplay.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.tabConsole.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.tlpStatus.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtConsole
        '
        Me.txtConsole.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConsole.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConsole.Font = New System.Drawing.Font("Lucida Console", 8.25!)
        Me.txtConsole.ForeColor = System.Drawing.Color.White
        Me.txtConsole.Location = New System.Drawing.Point(0, 0)
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ReadOnly = True
        Me.txtConsole.Size = New System.Drawing.Size(984, 483)
        Me.txtConsole.TabIndex = 110
        Me.txtConsole.Text = ""
        '
        'tabMenu
        '
        Me.tabMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMenu.CausesValidation = False
        Me.tabMenu.Controls.Add(Me.tabGames)
        Me.tabMenu.Controls.Add(Me.tabStandings)
        Me.tabMenu.Controls.Add(Me.tabSettings)
        Me.tabMenu.Controls.Add(Me.tabConsole)
        Me.tabMenu.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabMenu.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tabMenu.FontWeight = MetroFramework.MetroTabControlWeight.Regular
        Me.tabMenu.ItemSize = New System.Drawing.Size(120, 34)
        Me.tabMenu.Location = New System.Drawing.Point(-1, 70)
        Me.tabMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(992, 550)
        Me.tabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabMenu.Style = MetroFramework.MetroColorStyle.Red
        Me.tabMenu.TabIndex = 10
        Me.tabMenu.UseSelectable = True
        '
        'tabGames
        '
        Me.tabGames.Controls.Add(Me.spnLoading)
        Me.tabGames.Controls.Add(Me.lblDate)
        Me.tabGames.Controls.Add(Me.lblNoGames)
        Me.tabGames.Controls.Add(Me.flpCalendarPanel)
        Me.tabGames.Controls.Add(Me.flpGames)
        Me.tabGames.Controls.Add(Me.pnlGameBar)
        Me.tabGames.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabGames.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabGames.HorizontalScrollbarBarColor = False
        Me.tabGames.HorizontalScrollbarHighlightOnWheel = False
        Me.tabGames.HorizontalScrollbarSize = 10
        Me.tabGames.Location = New System.Drawing.Point(4, 38)
        Me.tabGames.Name = "tabGames"
        Me.tabGames.Padding = New System.Windows.Forms.Padding(1)
        Me.tabGames.Size = New System.Drawing.Size(984, 508)
        Me.tabGames.TabIndex = 0
        Me.tabGames.Text = "GAMES"
        Me.tabGames.UseVisualStyleBackColor = True
        Me.tabGames.VerticalScrollbarBarColor = False
        Me.tabGames.VerticalScrollbarHighlightOnWheel = False
        Me.tabGames.VerticalScrollbarSize = 10
        '
        'spnLoading
        '
        Me.spnLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.spnLoading.BackColor = System.Drawing.Color.White
        Me.spnLoading.Location = New System.Drawing.Point(200, 515)
        Me.spnLoading.Maximum = 1000
        Me.spnLoading.Name = "spnLoading"
        Me.spnLoading.Size = New System.Drawing.Size(80, 80)
        Me.spnLoading.Speed = 2.0!
        Me.spnLoading.Style = MetroFramework.MetroColorStyle.Red
        Me.spnLoading.TabIndex = 0
        Me.spnLoading.UseSelectable = True
        Me.spnLoading.Value = 1
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDate.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(40, 1)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(228, 40)
        Me.lblDate.TabIndex = 28
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDate.UseCustomBackColor = True
        Me.lblDate.UseCustomForeColor = True
        '
        'lblNoGames
        '
        Me.lblNoGames.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoGames.AutoSize = True
        Me.lblNoGames.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNoGames.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoGames.Location = New System.Drawing.Point(100, 515)
        Me.lblNoGames.Margin = New System.Windows.Forms.Padding(3)
        Me.lblNoGames.Name = "lblNoGames"
        Me.lblNoGames.Padding = New System.Windows.Forms.Padding(20, 6, 20, 6)
        Me.lblNoGames.Size = New System.Drawing.Size(156, 30)
        Me.lblNoGames.TabIndex = 25
        Me.lblNoGames.Text = "No Games Found"
        Me.lblNoGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoGames.Visible = False
        '
        'flpCalendarPanel
        '
        Me.flpCalendarPanel.AutoSize = True
        Me.flpCalendarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.flpCalendarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpCalendarPanel.Location = New System.Drawing.Point(38, 41)
        Me.flpCalendarPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.flpCalendarPanel.Name = "flpCalendarPanel"
        Me.flpCalendarPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.flpCalendarPanel.Size = New System.Drawing.Size(274, 20)
        Me.flpCalendarPanel.TabIndex = 10
        Me.flpCalendarPanel.Visible = False
        '
        'flpGames
        '
        Me.flpGames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpGames.AutoScroll = True
        Me.flpGames.BackColor = System.Drawing.Color.White
        Me.flpGames.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.flpGames.Location = New System.Drawing.Point(1, 41)
        Me.flpGames.Margin = New System.Windows.Forms.Padding(0)
        Me.flpGames.Name = "flpGames"
        Me.flpGames.Padding = New System.Windows.Forms.Padding(3)
        Me.flpGames.Size = New System.Drawing.Size(982, 465)
        Me.flpGames.TabIndex = 1
        '
        'pnlGameBar
        '
        Me.pnlGameBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGameBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlGameBar.Controls.Add(Me.btnTomorrow)
        Me.pnlGameBar.Controls.Add(Me.btnYesterday)
        Me.pnlGameBar.Controls.Add(Me.btnDate)
        Me.pnlGameBar.Controls.Add(Me.btnRefresh)
        Me.pnlGameBar.HorizontalScrollbarBarColor = True
        Me.pnlGameBar.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlGameBar.HorizontalScrollbarSize = 10
        Me.pnlGameBar.Location = New System.Drawing.Point(1, 0)
        Me.pnlGameBar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlGameBar.Name = "pnlGameBar"
        Me.pnlGameBar.Size = New System.Drawing.Size(982, 41)
        Me.pnlGameBar.TabIndex = 141
        Me.pnlGameBar.UseCustomBackColor = True
        Me.pnlGameBar.VerticalScrollbarBarColor = True
        Me.pnlGameBar.VerticalScrollbarHighlightOnWheel = True
        Me.pnlGameBar.VerticalScrollbarSize = 10
        '
        'btnTomorrow
        '
        Me.btnTomorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnTomorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTomorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTomorrow.FlatAppearance.BorderSize = 0
        Me.btnTomorrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnTomorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnTomorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnTomorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTomorrow.Location = New System.Drawing.Point(310, 8)
        Me.btnTomorrow.Name = "btnTomorrow"
        Me.btnTomorrow.Size = New System.Drawing.Size(24, 24)
        Me.btnTomorrow.TabIndex = 130
        Me.btnTomorrow.UseVisualStyleBackColor = False
        '
        'btnYesterday
        '
        Me.btnYesterday.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnYesterday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnYesterday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnYesterday.FlatAppearance.BorderSize = 0
        Me.btnYesterday.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnYesterday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnYesterday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnYesterday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYesterday.Location = New System.Drawing.Point(8, 8)
        Me.btnYesterday.Name = "btnYesterday"
        Me.btnYesterday.Size = New System.Drawing.Size(24, 24)
        Me.btnYesterday.TabIndex = 110
        Me.btnYesterday.UseVisualStyleBackColor = False
        '
        'btnDate
        '
        Me.btnDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDate.FlatAppearance.BorderSize = 0
        Me.btnDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDate.Location = New System.Drawing.Point(275, 8)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(24, 24)
        Me.btnDate.TabIndex = 120
        Me.btnDate.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.Location = New System.Drawing.Point(942, 8)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(24, 24)
        Me.btnRefresh.TabIndex = 140
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'tabStandings
        '
        Me.tabStandings.Controls.Add(Me.tlpStandings)
        Me.tabStandings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabStandings.HorizontalScrollbarBarColor = False
        Me.tabStandings.HorizontalScrollbarHighlightOnWheel = False
        Me.tabStandings.HorizontalScrollbarSize = 10
        Me.tabStandings.Location = New System.Drawing.Point(4, 38)
        Me.tabStandings.Name = "tabStandings"
        Me.tabStandings.Padding = New System.Windows.Forms.Padding(1)
        Me.tabStandings.Size = New System.Drawing.Size(984, 508)
        Me.tabStandings.TabIndex = 1
        Me.tabStandings.Text = "STANDINGS"
        Me.tabStandings.UseCustomForeColor = True
        Me.tabStandings.UseStyleColors = True
        Me.tabStandings.VerticalScrollbarBarColor = False
        Me.tabStandings.VerticalScrollbarHighlightOnWheel = False
        Me.tabStandings.VerticalScrollbarSize = 10
        '
        'tlpStandings
        '
        Me.tlpStandings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpStandings.AutoScroll = True
        Me.tlpStandings.BackColor = System.Drawing.Color.White
        Me.tlpStandings.ColumnCount = 3
        Me.tlpStandings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpStandings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpStandings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStandings.Controls.Add(Me.cbSeasons, 2, 1)
        Me.tlpStandings.Controls.Add(Me.lblSeason, 0, 1)
        Me.tlpStandings.Controls.Add(Me.tbStanding, 0, 2)
        Me.tlpStandings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlpStandings.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tlpStandings.Location = New System.Drawing.Point(1, 1)
        Me.tlpStandings.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpStandings.Name = "tlpStandings"
        Me.tlpStandings.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.tlpStandings.RowCount = 3
        Me.tlpStandings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpStandings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpStandings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStandings.Size = New System.Drawing.Size(982, 514)
        Me.tlpStandings.TabIndex = 2
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSeason.Location = New System.Drawing.Point(20, 30)
        Me.lblSeason.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(60, 31)
        Me.lblSeason.Style = MetroFramework.MetroColorStyle.Red
        Me.lblSeason.TabIndex = 3
        Me.lblSeason.Text = "SEASON"
        Me.lblSeason.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbStanding
        '
        Me.tbStanding.CausesValidation = False
        Me.tlpStandings.SetColumnSpan(Me.tbStanding, 3)
        Me.tbStanding.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbStanding.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tbStanding.FontWeight = MetroFramework.MetroTabControlWeight.Regular
        Me.tbStanding.ItemSize = New System.Drawing.Size(120, 34)
        Me.tbStanding.Location = New System.Drawing.Point(23, 64)
        Me.tbStanding.Name = "tbStanding"
        Me.tbStanding.Size = New System.Drawing.Size(936, 447)
        Me.tbStanding.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tbStanding.Style = MetroFramework.MetroColorStyle.Red
        Me.tbStanding.TabIndex = 502
        Me.tbStanding.UseSelectable = True
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.tlpSettings)
        Me.tabSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabSettings.HorizontalScrollbarBarColor = False
        Me.tabSettings.HorizontalScrollbarHighlightOnWheel = False
        Me.tabSettings.HorizontalScrollbarSize = 10
        Me.tabSettings.Location = New System.Drawing.Point(4, 38)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(1)
        Me.tabSettings.Size = New System.Drawing.Size(984, 508)
        Me.tabSettings.TabIndex = 1
        Me.tabSettings.Text = "SETTINGS"
        Me.tabSettings.UseCustomForeColor = True
        Me.tabSettings.UseStyleColors = True
        Me.tabSettings.VerticalScrollbarBarColor = False
        Me.tabSettings.VerticalScrollbarHighlightOnWheel = False
        Me.tabSettings.VerticalScrollbarSize = 10
        '
        'tlpSettings
        '
        Me.tlpSettings.AutoScroll = True
        Me.tlpSettings.AutoSize = True
        Me.tlpSettings.BackColor = System.Drawing.Color.White
        Me.tlpSettings.ColumnCount = 3
        Me.tlpSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSettings.Controls.Add(Me.tlpOBSSettings, 2, 28)
        Me.tlpSettings.Controls.Add(Me.flpObsDescSettings, 2, 27)
        Me.tlpSettings.Controls.Add(Me.flpSpotifyDescSettings, 2, 25)
        Me.tlpSettings.Controls.Add(Me.cbStreamQuality, 2, 3)
        Me.tlpSettings.Controls.Add(Me.lblStreamerArgs, 0, 22)
        Me.tlpSettings.Controls.Add(Me.lblPlayerArgs, 0, 21)
        Me.tlpSettings.Controls.Add(Me.lblOutput, 0, 20)
        Me.tlpSettings.Controls.Add(Me.flpStreamerArgs, 2, 22)
        Me.tlpSettings.Controls.Add(Me.flpPlayerArgs, 2, 21)
        Me.tlpSettings.Controls.Add(Me.flpOutputSettings, 2, 20)
        Me.tlpSettings.Controls.Add(Me.flpStreamerPath, 2, 15)
        Me.tlpSettings.Controls.Add(Me.flpMpvPath, 2, 12)
        Me.tlpSettings.Controls.Add(Me.flpMpcPath, 2, 14)
        Me.tlpSettings.Controls.Add(Me.flpVlcPath, 2, 13)
        Me.tlpSettings.Controls.Add(Me.lblLanguage, 0, 18)
        Me.tlpSettings.Controls.Add(Me.flpLanguage, 2, 18)
        Me.tlpSettings.Controls.Add(Me.lblSlPath, 0, 15)
        Me.tlpSettings.Controls.Add(Me.lblMpvPath, 0, 12)
        Me.tlpSettings.Controls.Add(Me.lblMpcPath, 0, 14)
        Me.tlpSettings.Controls.Add(Me.lblVlcPath, 0, 13)
        Me.tlpSettings.Controls.Add(Me.lblHostname, 0, 8)
        Me.tlpSettings.Controls.Add(Me.lblQuality, 0, 3)
        Me.tlpSettings.Controls.Add(Me.lblGamePanel, 0, 1)
        Me.tlpSettings.Controls.Add(Me.lblProxyPort, 0, 9)
        Me.tlpSettings.Controls.Add(Me.cbServers, 2, 8)
        Me.tlpSettings.Controls.Add(Me.flpHostsFile, 2, 9)
        Me.tlpSettings.Controls.Add(Me.tlpGamePanelSettings, 2, 1)
        Me.tlpSettings.Controls.Add(Me.lblPlayer, 0, 11)
        Me.tlpSettings.Controls.Add(Me.flpSelectedPlayer, 2, 11)
        Me.tlpSettings.Controls.Add(Me.tlpCdnSettings, 2, 7)
        Me.tlpSettings.Controls.Add(Me.lblMedia, 0, 25)
        Me.tlpSettings.Controls.Add(Me.lblOBS, 0, 27)
        Me.tlpSettings.Controls.Add(Me.flpSpotifyParameters, 2, 26)
        Me.tlpSettings.Controls.Add(Me.lblModules, 0, 24)
        Me.tlpSettings.Controls.Add(Me.flpAdDetection, 2, 24)
        Me.tlpSettings.Controls.Add(Me.tlpReplay, 2, 5)
        Me.tlpSettings.Controls.Add(Me.lblLiveRewind, 0, 5)
        Me.tlpSettings.Controls.Add(Me.lblCdn, 0, 7)
        Me.tlpSettings.Controls.Add(Me.lblLiveReplay, 0, 4)
        Me.tlpSettings.Controls.Add(Me.cbLiveReplay, 2, 4)
        Me.tlpSettings.Controls.Add(Me.tgDarkMode, 2, 17)
        Me.tlpSettings.Controls.Add(Me.lblDarkMode, 0, 17)
        Me.tlpSettings.Controls.Add(Me.lblReset, 0, 30)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel2, 2, 30)
        Me.tlpSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlpSettings.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tlpSettings.Location = New System.Drawing.Point(1, 1)
        Me.tlpSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpSettings.Name = "tlpSettings"
        Me.tlpSettings.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.tlpSettings.RowCount = 32
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpSettings.Size = New System.Drawing.Size(982, 506)
        Me.tlpSettings.TabIndex = 2
        '
        'tlpOBSSettings
        '
        Me.tlpOBSSettings.AutoSize = True
        Me.tlpOBSSettings.ColumnCount = 2
        Me.tlpOBSSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpOBSSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpOBSSettings.Controls.Add(Me.lblObsAdEndingHotkey, 0, 0)
        Me.tlpOBSSettings.Controls.Add(Me.lblObsAdStartingHotkey, 0, 1)
        Me.tlpOBSSettings.Controls.Add(Me.flpGameSceneHotkey, 1, 0)
        Me.tlpOBSSettings.Controls.Add(Me.flpAdSceneHotkey, 1, 1)
        Me.tlpOBSSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOBSSettings.Enabled = False
        Me.tlpOBSSettings.Location = New System.Drawing.Point(174, 990)
        Me.tlpOBSSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpOBSSettings.Name = "tlpOBSSettings"
        Me.tlpOBSSettings.RowCount = 2
        Me.tlpOBSSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpOBSSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpOBSSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpOBSSettings.Size = New System.Drawing.Size(771, 60)
        Me.tlpOBSSettings.TabIndex = 84
        '
        'lblObsAdEndingHotkey
        '
        Me.lblObsAdEndingHotkey.AutoSize = True
        Me.lblObsAdEndingHotkey.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblObsAdEndingHotkey.Location = New System.Drawing.Point(3, 3)
        Me.lblObsAdEndingHotkey.Margin = New System.Windows.Forms.Padding(3)
        Me.lblObsAdEndingHotkey.Name = "lblObsAdEndingHotkey"
        Me.lblObsAdEndingHotkey.Size = New System.Drawing.Size(146, 24)
        Me.lblObsAdEndingHotkey.Style = MetroFramework.MetroColorStyle.Red
        Me.lblObsAdEndingHotkey.TabIndex = 0
        Me.lblObsAdEndingHotkey.Text = "GAME_SCENE_HOTKEY"
        Me.lblObsAdEndingHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObsAdStartingHotkey
        '
        Me.lblObsAdStartingHotkey.AutoSize = True
        Me.lblObsAdStartingHotkey.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblObsAdStartingHotkey.Location = New System.Drawing.Point(3, 33)
        Me.lblObsAdStartingHotkey.Margin = New System.Windows.Forms.Padding(3)
        Me.lblObsAdStartingHotkey.Name = "lblObsAdStartingHotkey"
        Me.lblObsAdStartingHotkey.Size = New System.Drawing.Size(127, 24)
        Me.lblObsAdStartingHotkey.Style = MetroFramework.MetroColorStyle.Red
        Me.lblObsAdStartingHotkey.TabIndex = 1
        Me.lblObsAdStartingHotkey.Text = "AD_SCENE_HOTKEY"
        Me.lblObsAdStartingHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'flpGameSceneHotkey
        '
        Me.flpGameSceneHotkey.Controls.Add(Me.txtGameKey)
        Me.flpGameSceneHotkey.Controls.Add(Me.lblPlus1)
        Me.flpGameSceneHotkey.Controls.Add(Me.chkGameCtrl)
        Me.flpGameSceneHotkey.Controls.Add(Me.lblPlus2)
        Me.flpGameSceneHotkey.Controls.Add(Me.chkGameAlt)
        Me.flpGameSceneHotkey.Controls.Add(Me.lblPlus3)
        Me.flpGameSceneHotkey.Controls.Add(Me.chkGameShift)
        Me.flpGameSceneHotkey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpGameSceneHotkey.Location = New System.Drawing.Point(152, 0)
        Me.flpGameSceneHotkey.Margin = New System.Windows.Forms.Padding(0)
        Me.flpGameSceneHotkey.Name = "flpGameSceneHotkey"
        Me.flpGameSceneHotkey.Size = New System.Drawing.Size(619, 30)
        Me.flpGameSceneHotkey.TabIndex = 2
        '
        'txtGameKey
        '
        '
        '
        '
        Me.txtGameKey.CustomButton.Image = Nothing
        Me.txtGameKey.CustomButton.Location = New System.Drawing.Point(1, 1)
        Me.txtGameKey.CustomButton.Name = ""
        Me.txtGameKey.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtGameKey.CustomButton.Style = MetroFramework.MetroColorStyle.Red
        Me.txtGameKey.CustomButton.TabIndex = 1
        Me.txtGameKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGameKey.CustomButton.UseSelectable = True
        Me.txtGameKey.CustomButton.Visible = False
        Me.txtGameKey.Lines = New String(-1) {}
        Me.txtGameKey.Location = New System.Drawing.Point(3, 3)
        Me.txtGameKey.MaxLength = 1
        Me.txtGameKey.Name = "txtGameKey"
        Me.txtGameKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGameKey.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGameKey.SelectedText = ""
        Me.txtGameKey.SelectionLength = 0
        Me.txtGameKey.SelectionStart = 0
        Me.txtGameKey.ShortcutsEnabled = True
        Me.txtGameKey.Size = New System.Drawing.Size(23, 23)
        Me.txtGameKey.Style = MetroFramework.MetroColorStyle.Red
        Me.txtGameKey.TabIndex = 2
        Me.txtGameKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGameKey.UseSelectable = True
        Me.txtGameKey.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGameKey.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPlus1
        '
        Me.lblPlus1.AutoSize = True
        Me.lblPlus1.Location = New System.Drawing.Point(32, 3)
        Me.lblPlus1.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPlus1.Name = "lblPlus1"
        Me.lblPlus1.Size = New System.Drawing.Size(18, 19)
        Me.lblPlus1.Style = MetroFramework.MetroColorStyle.Red
        Me.lblPlus1.TabIndex = 3
        Me.lblPlus1.Text = "+"
        '
        'chkGameCtrl
        '
        Me.chkGameCtrl.AutoSize = True
        Me.chkGameCtrl.Location = New System.Drawing.Point(56, 6)
        Me.chkGameCtrl.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkGameCtrl.Name = "chkGameCtrl"
        Me.chkGameCtrl.Size = New System.Drawing.Size(50, 15)
        Me.chkGameCtrl.Style = MetroFramework.MetroColorStyle.Red
        Me.chkGameCtrl.TabIndex = 4
        Me.chkGameCtrl.Text = "CTRL"
        Me.chkGameCtrl.UseSelectable = True
        '
        'lblPlus2
        '
        Me.lblPlus2.AutoSize = True
        Me.lblPlus2.Location = New System.Drawing.Point(112, 3)
        Me.lblPlus2.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPlus2.Name = "lblPlus2"
        Me.lblPlus2.Size = New System.Drawing.Size(18, 19)
        Me.lblPlus2.Style = MetroFramework.MetroColorStyle.Red
        Me.lblPlus2.TabIndex = 5
        Me.lblPlus2.Text = "+"
        '
        'chkGameAlt
        '
        Me.chkGameAlt.AutoSize = True
        Me.chkGameAlt.Location = New System.Drawing.Point(136, 6)
        Me.chkGameAlt.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkGameAlt.Name = "chkGameAlt"
        Me.chkGameAlt.Size = New System.Drawing.Size(42, 15)
        Me.chkGameAlt.Style = MetroFramework.MetroColorStyle.Red
        Me.chkGameAlt.TabIndex = 6
        Me.chkGameAlt.Text = "ALT"
        Me.chkGameAlt.UseSelectable = True
        '
        'lblPlus3
        '
        Me.lblPlus3.AutoSize = True
        Me.lblPlus3.Location = New System.Drawing.Point(184, 3)
        Me.lblPlus3.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPlus3.Name = "lblPlus3"
        Me.lblPlus3.Size = New System.Drawing.Size(18, 19)
        Me.lblPlus3.Style = MetroFramework.MetroColorStyle.Red
        Me.lblPlus3.TabIndex = 7
        Me.lblPlus3.Text = "+"
        '
        'chkGameShift
        '
        Me.chkGameShift.AutoSize = True
        Me.chkGameShift.Location = New System.Drawing.Point(208, 6)
        Me.chkGameShift.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkGameShift.Name = "chkGameShift"
        Me.chkGameShift.Size = New System.Drawing.Size(53, 15)
        Me.chkGameShift.Style = MetroFramework.MetroColorStyle.Red
        Me.chkGameShift.TabIndex = 8
        Me.chkGameShift.Text = "SHIFT"
        Me.chkGameShift.UseSelectable = True
        '
        'flpAdSceneHotkey
        '
        Me.flpAdSceneHotkey.Controls.Add(Me.txtAdKey)
        Me.flpAdSceneHotkey.Controls.Add(Me.lblPlus4)
        Me.flpAdSceneHotkey.Controls.Add(Me.chkAdCtrl)
        Me.flpAdSceneHotkey.Controls.Add(Me.lblPlus5)
        Me.flpAdSceneHotkey.Controls.Add(Me.chkAdAlt)
        Me.flpAdSceneHotkey.Controls.Add(Me.lblPlus6)
        Me.flpAdSceneHotkey.Controls.Add(Me.chkAdShift)
        Me.flpAdSceneHotkey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpAdSceneHotkey.Location = New System.Drawing.Point(152, 30)
        Me.flpAdSceneHotkey.Margin = New System.Windows.Forms.Padding(0)
        Me.flpAdSceneHotkey.Name = "flpAdSceneHotkey"
        Me.flpAdSceneHotkey.Size = New System.Drawing.Size(619, 30)
        Me.flpAdSceneHotkey.TabIndex = 3
        '
        'txtAdKey
        '
        '
        '
        '
        Me.txtAdKey.CustomButton.Image = Nothing
        Me.txtAdKey.CustomButton.Location = New System.Drawing.Point(1, 1)
        Me.txtAdKey.CustomButton.Name = ""
        Me.txtAdKey.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAdKey.CustomButton.Style = MetroFramework.MetroColorStyle.Red
        Me.txtAdKey.CustomButton.TabIndex = 1
        Me.txtAdKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdKey.CustomButton.UseSelectable = True
        Me.txtAdKey.CustomButton.Visible = False
        Me.txtAdKey.Lines = New String(-1) {}
        Me.txtAdKey.Location = New System.Drawing.Point(3, 3)
        Me.txtAdKey.MaxLength = 1
        Me.txtAdKey.Name = "txtAdKey"
        Me.txtAdKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdKey.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdKey.SelectedText = ""
        Me.txtAdKey.SelectionLength = 0
        Me.txtAdKey.SelectionStart = 0
        Me.txtAdKey.ShortcutsEnabled = True
        Me.txtAdKey.Size = New System.Drawing.Size(23, 23)
        Me.txtAdKey.Style = MetroFramework.MetroColorStyle.Red
        Me.txtAdKey.TabIndex = 3
        Me.txtAdKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAdKey.UseSelectable = True
        Me.txtAdKey.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdKey.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPlus4
        '
        Me.lblPlus4.AutoSize = True
        Me.lblPlus4.Location = New System.Drawing.Point(32, 3)
        Me.lblPlus4.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPlus4.Name = "lblPlus4"
        Me.lblPlus4.Size = New System.Drawing.Size(18, 19)
        Me.lblPlus4.Style = MetroFramework.MetroColorStyle.Red
        Me.lblPlus4.TabIndex = 4
        Me.lblPlus4.Text = "+"
        '
        'chkAdCtrl
        '
        Me.chkAdCtrl.AutoSize = True
        Me.chkAdCtrl.Location = New System.Drawing.Point(56, 6)
        Me.chkAdCtrl.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkAdCtrl.Name = "chkAdCtrl"
        Me.chkAdCtrl.Size = New System.Drawing.Size(50, 15)
        Me.chkAdCtrl.Style = MetroFramework.MetroColorStyle.Red
        Me.chkAdCtrl.TabIndex = 5
        Me.chkAdCtrl.Text = "CTRL"
        Me.chkAdCtrl.UseSelectable = True
        '
        'lblPlus5
        '
        Me.lblPlus5.AutoSize = True
        Me.lblPlus5.Location = New System.Drawing.Point(112, 3)
        Me.lblPlus5.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPlus5.Name = "lblPlus5"
        Me.lblPlus5.Size = New System.Drawing.Size(18, 19)
        Me.lblPlus5.Style = MetroFramework.MetroColorStyle.Red
        Me.lblPlus5.TabIndex = 6
        Me.lblPlus5.Text = "+"
        '
        'chkAdAlt
        '
        Me.chkAdAlt.AutoSize = True
        Me.chkAdAlt.Location = New System.Drawing.Point(136, 6)
        Me.chkAdAlt.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkAdAlt.Name = "chkAdAlt"
        Me.chkAdAlt.Size = New System.Drawing.Size(42, 15)
        Me.chkAdAlt.Style = MetroFramework.MetroColorStyle.Red
        Me.chkAdAlt.TabIndex = 7
        Me.chkAdAlt.Text = "ALT"
        Me.chkAdAlt.UseSelectable = True
        '
        'lblPlus6
        '
        Me.lblPlus6.AutoSize = True
        Me.lblPlus6.Location = New System.Drawing.Point(184, 3)
        Me.lblPlus6.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPlus6.Name = "lblPlus6"
        Me.lblPlus6.Size = New System.Drawing.Size(18, 19)
        Me.lblPlus6.Style = MetroFramework.MetroColorStyle.Red
        Me.lblPlus6.TabIndex = 8
        Me.lblPlus6.Text = "+"
        '
        'chkAdShift
        '
        Me.chkAdShift.AutoSize = True
        Me.chkAdShift.Location = New System.Drawing.Point(208, 6)
        Me.chkAdShift.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkAdShift.Name = "chkAdShift"
        Me.chkAdShift.Size = New System.Drawing.Size(53, 15)
        Me.chkAdShift.Style = MetroFramework.MetroColorStyle.Red
        Me.chkAdShift.TabIndex = 9
        Me.chkAdShift.Text = "SHIFT"
        Me.chkAdShift.UseSelectable = True
        '
        'flpObsDescSettings
        '
        Me.flpObsDescSettings.Controls.Add(Me.tgOBS)
        Me.flpObsDescSettings.Controls.Add(Me.lblOBSDesc)
        Me.flpObsDescSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpObsDescSettings.Location = New System.Drawing.Point(174, 960)
        Me.flpObsDescSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.flpObsDescSettings.Name = "flpObsDescSettings"
        Me.flpObsDescSettings.Size = New System.Drawing.Size(771, 30)
        Me.flpObsDescSettings.TabIndex = 83
        '
        'tgOBS
        '
        Me.tgOBS.AutoSize = True
        Me.tgOBS.Enabled = False
        Me.tgOBS.Location = New System.Drawing.Point(3, 3)
        Me.tgOBS.Name = "tgOBS"
        Me.tgOBS.Size = New System.Drawing.Size(80, 19)
        Me.tgOBS.Style = MetroFramework.MetroColorStyle.Red
        Me.tgOBS.TabIndex = 81
        Me.tgOBS.Text = "Off"
        Me.tgOBS.UseSelectable = True
        '
        'lblOBSDesc
        '
        Me.lblOBSDesc.AutoSize = True
        Me.lblOBSDesc.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblOBSDesc.Location = New System.Drawing.Point(91, 5)
        Me.lblOBSDesc.Margin = New System.Windows.Forms.Padding(5)
        Me.lblOBSDesc.Name = "lblOBSDesc"
        Me.lblOBSDesc.Size = New System.Drawing.Size(61, 15)
        Me.lblOBSDesc.Style = MetroFramework.MetroColorStyle.Red
        Me.lblOBSDesc.TabIndex = 82
        Me.lblOBSDesc.Text = "OBS_DESC"
        Me.lblOBSDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'flpSpotifyDescSettings
        '
        Me.flpSpotifyDescSettings.Controls.Add(Me.tgMedia)
        Me.flpSpotifyDescSettings.Controls.Add(Me.lblMediaDesc)
        Me.flpSpotifyDescSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpSpotifyDescSettings.Location = New System.Drawing.Point(174, 900)
        Me.flpSpotifyDescSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.flpSpotifyDescSettings.Name = "flpSpotifyDescSettings"
        Me.flpSpotifyDescSettings.Size = New System.Drawing.Size(771, 30)
        Me.flpSpotifyDescSettings.TabIndex = 76
        '
        'tgMedia
        '
        Me.tgMedia.AutoSize = True
        Me.tgMedia.Enabled = False
        Me.tgMedia.Location = New System.Drawing.Point(3, 3)
        Me.tgMedia.Name = "tgMedia"
        Me.tgMedia.Size = New System.Drawing.Size(80, 19)
        Me.tgMedia.Style = MetroFramework.MetroColorStyle.Red
        Me.tgMedia.TabIndex = 74
        Me.tgMedia.Text = "Off"
        Me.tgMedia.UseSelectable = True
        '
        'lblMediaDesc
        '
        Me.lblMediaDesc.AutoSize = True
        Me.lblMediaDesc.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblMediaDesc.Location = New System.Drawing.Point(91, 5)
        Me.lblMediaDesc.Margin = New System.Windows.Forms.Padding(5)
        Me.lblMediaDesc.Name = "lblMediaDesc"
        Me.lblMediaDesc.Size = New System.Drawing.Size(74, 15)
        Me.lblMediaDesc.Style = MetroFramework.MetroColorStyle.Red
        Me.lblMediaDesc.TabIndex = 75
        Me.lblMediaDesc.Text = "MEDIA_DESC"
        Me.lblMediaDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStreamerArgs
        '
        Me.lblStreamerArgs.AutoSize = True
        Me.lblStreamerArgs.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblStreamerArgs.Location = New System.Drawing.Point(38, 783)
        Me.lblStreamerArgs.Margin = New System.Windows.Forms.Padding(3)
        Me.lblStreamerArgs.Name = "lblStreamerArgs"
        Me.lblStreamerArgs.Size = New System.Drawing.Size(113, 54)
        Me.lblStreamerArgs.Style = MetroFramework.MetroColorStyle.Red
        Me.lblStreamerArgs.TabIndex = 6
        Me.lblStreamerArgs.Text = "STREAMER_ARGS"
        Me.lblStreamerArgs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPlayerArgs
        '
        Me.lblPlayerArgs.AutoSize = True
        Me.lblPlayerArgs.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPlayerArgs.Location = New System.Drawing.Point(58, 723)
        Me.lblPlayerArgs.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPlayerArgs.Name = "lblPlayerArgs"
        Me.lblPlayerArgs.Size = New System.Drawing.Size(93, 54)
        Me.lblPlayerArgs.Style = MetroFramework.MetroColorStyle.Red
        Me.lblPlayerArgs.TabIndex = 5
        Me.lblPlayerArgs.Text = "PLAYER_ARGS"
        Me.lblPlayerArgs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblOutput.Location = New System.Drawing.Point(94, 690)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(60, 30)
        Me.lblOutput.Style = MetroFramework.MetroColorStyle.Red
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "OUTPUT"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flpStreamerArgs
        '
        Me.flpStreamerArgs.Controls.Add(Me.tgStreamer)
        Me.flpStreamerArgs.Controls.Add(Me.txtStreamerArgs)
        Me.flpStreamerArgs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpStreamerArgs.Location = New System.Drawing.Point(174, 780)
        Me.flpStreamerArgs.Margin = New System.Windows.Forms.Padding(0)
        Me.flpStreamerArgs.Name = "flpStreamerArgs"
        Me.flpStreamerArgs.Size = New System.Drawing.Size(771, 60)
        Me.flpStreamerArgs.TabIndex = 64
        '
        'tgStreamer
        '
        Me.tgStreamer.AutoSize = True
        Me.tgStreamer.Location = New System.Drawing.Point(3, 3)
        Me.tgStreamer.Name = "tgStreamer"
        Me.tgStreamer.Size = New System.Drawing.Size(80, 19)
        Me.tgStreamer.Style = MetroFramework.MetroColorStyle.Red
        Me.tgStreamer.TabIndex = 1320
        Me.tgStreamer.Text = "Off"
        Me.tgStreamer.UseSelectable = True
        '
        'txtStreamerArgs
        '
        Me.txtStreamerArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStreamerArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreamerArgs.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreamerArgs.Location = New System.Drawing.Point(89, 3)
        Me.txtStreamerArgs.Margin = New System.Windows.Forms.Padding(3, 3, 50, 3)
        Me.txtStreamerArgs.Multiline = True
        Me.txtStreamerArgs.Name = "txtStreamerArgs"
        Me.txtStreamerArgs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStreamerArgs.Size = New System.Drawing.Size(514, 57)
        Me.txtStreamerArgs.TabIndex = 1310
        '
        'flpPlayerArgs
        '
        Me.flpPlayerArgs.Controls.Add(Me.tgPlayer)
        Me.flpPlayerArgs.Controls.Add(Me.txtPlayerArgs)
        Me.flpPlayerArgs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpPlayerArgs.Location = New System.Drawing.Point(174, 720)
        Me.flpPlayerArgs.Margin = New System.Windows.Forms.Padding(0)
        Me.flpPlayerArgs.Name = "flpPlayerArgs"
        Me.flpPlayerArgs.Size = New System.Drawing.Size(771, 60)
        Me.flpPlayerArgs.TabIndex = 64
        '
        'tgPlayer
        '
        Me.tgPlayer.AutoSize = True
        Me.tgPlayer.Location = New System.Drawing.Point(3, 3)
        Me.tgPlayer.Name = "tgPlayer"
        Me.tgPlayer.Size = New System.Drawing.Size(80, 19)
        Me.tgPlayer.Style = MetroFramework.MetroColorStyle.Red
        Me.tgPlayer.TabIndex = 1220
        Me.tgPlayer.Text = "Off"
        Me.tgPlayer.UseSelectable = True
        '
        'txtPlayerArgs
        '
        Me.txtPlayerArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlayerArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlayerArgs.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerArgs.Location = New System.Drawing.Point(89, 3)
        Me.txtPlayerArgs.Margin = New System.Windows.Forms.Padding(3, 3, 50, 3)
        Me.txtPlayerArgs.Multiline = True
        Me.txtPlayerArgs.Name = "txtPlayerArgs"
        Me.txtPlayerArgs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPlayerArgs.Size = New System.Drawing.Size(514, 54)
        Me.txtPlayerArgs.TabIndex = 1210
        '
        'flpOutputSettings
        '
        Me.flpOutputSettings.Controls.Add(Me.tgOutput)
        Me.flpOutputSettings.Controls.Add(Me.txtOutputArgs)
        Me.flpOutputSettings.Controls.Add(Me.btnOutput)
        Me.flpOutputSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpOutputSettings.Location = New System.Drawing.Point(174, 690)
        Me.flpOutputSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.flpOutputSettings.Name = "flpOutputSettings"
        Me.flpOutputSettings.Size = New System.Drawing.Size(771, 30)
        Me.flpOutputSettings.TabIndex = 64
        '
        'tgOutput
        '
        Me.tgOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tgOutput.AutoSize = True
        Me.tgOutput.Location = New System.Drawing.Point(3, 3)
        Me.tgOutput.Name = "tgOutput"
        Me.tgOutput.Size = New System.Drawing.Size(80, 19)
        Me.tgOutput.Style = MetroFramework.MetroColorStyle.Red
        Me.tgOutput.TabIndex = 1130
        Me.tgOutput.Text = "Off"
        Me.tgOutput.UseSelectable = True
        '
        'txtOutputArgs
        '
        Me.txtOutputArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutputArgs.Enabled = False
        Me.txtOutputArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOutputArgs.Location = New System.Drawing.Point(89, 3)
        Me.txtOutputArgs.Name = "txtOutputArgs"
        Me.txtOutputArgs.Size = New System.Drawing.Size(514, 22)
        Me.txtOutputArgs.TabIndex = 1110
        '
        'btnOutput
        '
        Me.btnOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOutput.Location = New System.Drawing.Point(609, 3)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(40, 20)
        Me.btnOutput.Style = MetroFramework.MetroColorStyle.Red
        Me.btnOutput.TabIndex = 1120
        Me.btnOutput.Text = "..."
        Me.btnOutput.UseSelectable = True
        '
        'flpStreamerPath
        '
        Me.flpStreamerPath.Controls.Add(Me.txtStreamerPath)
        Me.flpStreamerPath.Controls.Add(Me.btnStreamerPath)
        Me.flpStreamerPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpStreamerPath.Location = New System.Drawing.Point(174, 540)
        Me.flpStreamerPath.Margin = New System.Windows.Forms.Padding(0)
        Me.flpStreamerPath.Name = "flpStreamerPath"
        Me.flpStreamerPath.Size = New System.Drawing.Size(771, 30)
        Me.flpStreamerPath.TabIndex = 64
        '
        'txtStreamerPath
        '
        Me.txtStreamerPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStreamerPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreamerPath.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtStreamerPath.Location = New System.Drawing.Point(3, 3)
        Me.txtStreamerPath.Name = "txtStreamerPath"
        Me.txtStreamerPath.ReadOnly = True
        Me.txtStreamerPath.Size = New System.Drawing.Size(600, 22)
        Me.txtStreamerPath.TabIndex = 1010
        '
        'btnStreamerPath
        '
        Me.btnStreamerPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStreamerPath.Location = New System.Drawing.Point(609, 3)
        Me.btnStreamerPath.Name = "btnStreamerPath"
        Me.btnStreamerPath.Size = New System.Drawing.Size(40, 22)
        Me.btnStreamerPath.Style = MetroFramework.MetroColorStyle.Red
        Me.btnStreamerPath.TabIndex = 1020
        Me.btnStreamerPath.Text = "..."
        Me.btnStreamerPath.UseSelectable = True
        '
        'flpMpvPath
        '
        Me.flpMpvPath.Controls.Add(Me.txtMpvPath)
        Me.flpMpvPath.Controls.Add(Me.btnMpvPath)
        Me.flpMpvPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpMpvPath.Location = New System.Drawing.Point(174, 450)
        Me.flpMpvPath.Margin = New System.Windows.Forms.Padding(0)
        Me.flpMpvPath.Name = "flpMpvPath"
        Me.flpMpvPath.Size = New System.Drawing.Size(771, 30)
        Me.flpMpvPath.TabIndex = 64
        '
        'txtMpvPath
        '
        Me.txtMpvPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMpvPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMpvPath.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMpvPath.Location = New System.Drawing.Point(3, 3)
        Me.txtMpvPath.Name = "txtMpvPath"
        Me.txtMpvPath.ReadOnly = True
        Me.txtMpvPath.Size = New System.Drawing.Size(600, 22)
        Me.txtMpvPath.TabIndex = 910
        '
        'btnMpvPath
        '
        Me.btnMpvPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMpvPath.Location = New System.Drawing.Point(609, 3)
        Me.btnMpvPath.Name = "btnMpvPath"
        Me.btnMpvPath.Size = New System.Drawing.Size(40, 22)
        Me.btnMpvPath.Style = MetroFramework.MetroColorStyle.Red
        Me.btnMpvPath.TabIndex = 920
        Me.btnMpvPath.Text = "..."
        Me.btnMpvPath.UseSelectable = True
        '
        'flpMpcPath
        '
        Me.flpMpcPath.Controls.Add(Me.txtMPCPath)
        Me.flpMpcPath.Controls.Add(Me.btnMPCPath)
        Me.flpMpcPath.Controls.Add(Me.lnkGetMpc)
        Me.flpMpcPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpMpcPath.Location = New System.Drawing.Point(174, 510)
        Me.flpMpcPath.Margin = New System.Windows.Forms.Padding(0)
        Me.flpMpcPath.Name = "flpMpcPath"
        Me.flpMpcPath.Size = New System.Drawing.Size(771, 30)
        Me.flpMpcPath.TabIndex = 64
        '
        'txtMPCPath
        '
        Me.txtMPCPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMPCPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMPCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtMPCPath.Location = New System.Drawing.Point(3, 3)
        Me.txtMPCPath.Name = "txtMPCPath"
        Me.txtMPCPath.ReadOnly = True
        Me.txtMPCPath.Size = New System.Drawing.Size(600, 22)
        Me.txtMPCPath.TabIndex = 810
        '
        'btnMPCPath
        '
        Me.btnMPCPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMPCPath.Location = New System.Drawing.Point(609, 3)
        Me.btnMPCPath.Name = "btnMPCPath"
        Me.btnMPCPath.Size = New System.Drawing.Size(40, 22)
        Me.btnMPCPath.Style = MetroFramework.MetroColorStyle.Red
        Me.btnMPCPath.TabIndex = 820
        Me.btnMPCPath.Text = "..."
        Me.btnMPCPath.UseSelectable = True
        '
        'lnkGetMpc
        '
        Me.lnkGetMpc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkGetMpc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkGetMpc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkGetMpc.ForeColor = System.Drawing.Color.Black
        Me.lnkGetMpc.ImageSize = 20
        Me.lnkGetMpc.Location = New System.Drawing.Point(655, 3)
        Me.lnkGetMpc.Name = "lnkGetMpc"
        Me.lnkGetMpc.Size = New System.Drawing.Size(25, 25)
        Me.lnkGetMpc.TabIndex = 830
        Me.tt.SetToolTip(Me.lnkGetMpc, "Download MPC")
        Me.lnkGetMpc.UseSelectable = True
        '
        'flpVlcPath
        '
        Me.flpVlcPath.Controls.Add(Me.txtVLCPath)
        Me.flpVlcPath.Controls.Add(Me.btnVLCPath)
        Me.flpVlcPath.Controls.Add(Me.lnkGetVlc)
        Me.flpVlcPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpVlcPath.Location = New System.Drawing.Point(174, 480)
        Me.flpVlcPath.Margin = New System.Windows.Forms.Padding(0)
        Me.flpVlcPath.Name = "flpVlcPath"
        Me.flpVlcPath.Size = New System.Drawing.Size(771, 30)
        Me.flpVlcPath.TabIndex = 64
        '
        'txtVLCPath
        '
        Me.txtVLCPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVLCPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVLCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtVLCPath.Location = New System.Drawing.Point(3, 3)
        Me.txtVLCPath.Name = "txtVLCPath"
        Me.txtVLCPath.ReadOnly = True
        Me.txtVLCPath.Size = New System.Drawing.Size(600, 22)
        Me.txtVLCPath.TabIndex = 710
        '
        'btnVLCPath
        '
        Me.btnVLCPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVLCPath.Location = New System.Drawing.Point(609, 3)
        Me.btnVLCPath.Name = "btnVLCPath"
        Me.btnVLCPath.Size = New System.Drawing.Size(40, 22)
        Me.btnVLCPath.Style = MetroFramework.MetroColorStyle.Red
        Me.btnVLCPath.TabIndex = 720
        Me.btnVLCPath.Text = "..."
        Me.btnVLCPath.UseSelectable = True
        '
        'lnkGetVlc
        '
        Me.lnkGetVlc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkGetVlc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkGetVlc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkGetVlc.ForeColor = System.Drawing.Color.Black
        Me.lnkGetVlc.ImageSize = 20
        Me.lnkGetVlc.Location = New System.Drawing.Point(655, 3)
        Me.lnkGetVlc.Name = "lnkGetVlc"
        Me.lnkGetVlc.Size = New System.Drawing.Size(25, 25)
        Me.lnkGetVlc.TabIndex = 730
        Me.lnkGetVlc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tt.SetToolTip(Me.lnkGetVlc, "Download VLC")
        Me.lnkGetVlc.UseSelectable = True
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblLanguage.Location = New System.Drawing.Point(76, 630)
        Me.lblLanguage.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(78, 30)
        Me.lblLanguage.Style = MetroFramework.MetroColorStyle.Red
        Me.lblLanguage.TabIndex = 69
        Me.lblLanguage.Text = "LANGUAGE"
        Me.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flpLanguage
        '
        Me.flpLanguage.Controls.Add(Me.cbLanguage)
        Me.flpLanguage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpLanguage.Location = New System.Drawing.Point(174, 630)
        Me.flpLanguage.Margin = New System.Windows.Forms.Padding(0)
        Me.flpLanguage.Name = "flpLanguage"
        Me.flpLanguage.Size = New System.Drawing.Size(771, 30)
        Me.flpLanguage.TabIndex = 70
        '
        'lblSlPath
        '
        Me.lblSlPath.AutoSize = True
        Me.lblSlPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSlPath.Location = New System.Drawing.Point(45, 540)
        Me.lblSlPath.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSlPath.Name = "lblSlPath"
        Me.lblSlPath.Size = New System.Drawing.Size(109, 30)
        Me.lblSlPath.Style = MetroFramework.MetroColorStyle.Red
        Me.lblSlPath.TabIndex = 47
        Me.lblSlPath.Text = "STREAMER_PATH"
        Me.lblSlPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMpvPath
        '
        Me.lblMpvPath.AutoSize = True
        Me.lblMpvPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMpvPath.Location = New System.Drawing.Point(82, 450)
        Me.lblMpvPath.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMpvPath.Name = "lblMpvPath"
        Me.lblMpvPath.Size = New System.Drawing.Size(72, 30)
        Me.lblMpvPath.Style = MetroFramework.MetroColorStyle.Red
        Me.lblMpvPath.TabIndex = 52
        Me.lblMpvPath.Text = "MPV_PATH"
        Me.lblMpvPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMpcPath
        '
        Me.lblMpcPath.AutoSize = True
        Me.lblMpcPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMpcPath.Location = New System.Drawing.Point(81, 510)
        Me.lblMpcPath.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMpcPath.Name = "lblMpcPath"
        Me.lblMpcPath.Size = New System.Drawing.Size(73, 30)
        Me.lblMpcPath.Style = MetroFramework.MetroColorStyle.Red
        Me.lblMpcPath.TabIndex = 44
        Me.lblMpcPath.Text = "MPC_PATH"
        Me.lblMpcPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlcPath
        '
        Me.lblVlcPath.AutoSize = True
        Me.lblVlcPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblVlcPath.Location = New System.Drawing.Point(88, 480)
        Me.lblVlcPath.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVlcPath.Name = "lblVlcPath"
        Me.lblVlcPath.Size = New System.Drawing.Size(66, 30)
        Me.lblVlcPath.Style = MetroFramework.MetroColorStyle.Red
        Me.lblVlcPath.TabIndex = 43
        Me.lblVlcPath.Text = "VLC_PATH"
        Me.lblVlcPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHostname
        '
        Me.lblHostname.AutoSize = True
        Me.lblHostname.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblHostname.Location = New System.Drawing.Point(73, 330)
        Me.lblHostname.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHostname.Name = "lblHostname"
        Me.lblHostname.Size = New System.Drawing.Size(81, 30)
        Me.lblHostname.Style = MetroFramework.MetroColorStyle.Red
        Me.lblHostname.TabIndex = 68
        Me.lblHostname.Text = "HOSTNAME"
        Me.lblHostname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuality
        '
        Me.lblQuality.AutoSize = True
        Me.lblQuality.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblQuality.Location = New System.Drawing.Point(36, 180)
        Me.lblQuality.Margin = New System.Windows.Forms.Padding(0)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(118, 30)
        Me.lblQuality.Style = MetroFramework.MetroColorStyle.Red
        Me.lblQuality.TabIndex = 2
        Me.lblQuality.Text = "STREAM_QUALITY"
        Me.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGamePanel
        '
        Me.lblGamePanel.AutoSize = True
        Me.lblGamePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblGamePanel.Location = New System.Drawing.Point(64, 30)
        Me.lblGamePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.lblGamePanel.Name = "lblGamePanel"
        Me.lblGamePanel.Size = New System.Drawing.Size(90, 120)
        Me.lblGamePanel.Style = MetroFramework.MetroColorStyle.Red
        Me.lblGamePanel.TabIndex = 57
        Me.lblGamePanel.Text = "GAME_PANEL"
        Me.lblGamePanel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblProxyPort
        '
        Me.lblProxyPort.AutoSize = True
        Me.lblProxyPort.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblProxyPort.Location = New System.Drawing.Point(59, 360)
        Me.lblProxyPort.Name = "lblProxyPort"
        Me.lblProxyPort.Size = New System.Drawing.Size(92, 30)
        Me.lblProxyPort.Style = MetroFramework.MetroColorStyle.Red
        Me.lblProxyPort.TabIndex = 72
        Me.lblProxyPort.Text = "PROXY_PORT"
        Me.lblProxyPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flpHostsFile
        '
        Me.flpHostsFile.Controls.Add(Me.lblProxyPortNumber)
        Me.flpHostsFile.Controls.Add(Me.tbProxyPort)
        Me.flpHostsFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpHostsFile.Location = New System.Drawing.Point(174, 360)
        Me.flpHostsFile.Margin = New System.Windows.Forms.Padding(0)
        Me.flpHostsFile.Name = "flpHostsFile"
        Me.flpHostsFile.Size = New System.Drawing.Size(771, 30)
        Me.flpHostsFile.TabIndex = 511
        '
        'lblProxyPortNumber
        '
        Me.lblProxyPortNumber.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblProxyPortNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblProxyPortNumber.Location = New System.Drawing.Point(3, 0)
        Me.lblProxyPortNumber.Name = "lblProxyPortNumber"
        Me.lblProxyPortNumber.Size = New System.Drawing.Size(60, 29)
        Me.lblProxyPortNumber.Style = MetroFramework.MetroColorStyle.Red
        Me.lblProxyPortNumber.TabIndex = 1
        Me.lblProxyPortNumber.Text = "000000"
        Me.lblProxyPortNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpGamePanelSettings
        '
        Me.tlpGamePanelSettings.ColumnCount = 4
        Me.tlpGamePanelSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpGamePanelSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpGamePanelSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpGamePanelSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpGamePanelSettings.Controls.Add(Me.tgShowStanding, 0, 3)
        Me.tlpGamePanelSettings.Controls.Add(Me.tgShowTodayLiveGamesFirst, 0, 0)
        Me.tlpGamePanelSettings.Controls.Add(Me.lblShowTodayLiveGamesFirst, 1, 0)
        Me.tlpGamePanelSettings.Controls.Add(Me.lblShowTeamCityAbr, 3, 1)
        Me.tlpGamePanelSettings.Controls.Add(Me.tgShowTeamCityAbr, 2, 1)
        Me.tlpGamePanelSettings.Controls.Add(Me.lblShowLiveScores, 1, 2)
        Me.tlpGamePanelSettings.Controls.Add(Me.tgShowLiveScores, 0, 2)
        Me.tlpGamePanelSettings.Controls.Add(Me.lblShowSeriesRecord, 3, 0)
        Me.tlpGamePanelSettings.Controls.Add(Me.lblShowFinalScores, 3, 2)
        Me.tlpGamePanelSettings.Controls.Add(Me.tgShowFinalScores, 2, 2)
        Me.tlpGamePanelSettings.Controls.Add(Me.tgShowSeriesRecord, 2, 0)
        Me.tlpGamePanelSettings.Controls.Add(Me.tgShowLiveTime, 0, 1)
        Me.tlpGamePanelSettings.Controls.Add(Me.lblShowLiveTime, 1, 1)
        Me.tlpGamePanelSettings.Controls.Add(Me.lblShowStanding, 1, 3)
        Me.tlpGamePanelSettings.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpGamePanelSettings.Location = New System.Drawing.Point(174, 30)
        Me.tlpGamePanelSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpGamePanelSettings.Name = "tlpGamePanelSettings"
        Me.tlpGamePanelSettings.RowCount = 4
        Me.tlpGamePanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpGamePanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpGamePanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpGamePanelSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpGamePanelSettings.Size = New System.Drawing.Size(758, 120)
        Me.tlpGamePanelSettings.TabIndex = 512
        '
        'tgShowStanding
        '
        Me.tgShowStanding.AutoSize = True
        Me.tgShowStanding.Location = New System.Drawing.Point(3, 93)
        Me.tgShowStanding.Name = "tgShowStanding"
        Me.tgShowStanding.Size = New System.Drawing.Size(80, 19)
        Me.tgShowStanding.Style = MetroFramework.MetroColorStyle.Red
        Me.tgShowStanding.TabIndex = 12
        Me.tgShowStanding.Text = "Off"
        Me.tgShowStanding.UseSelectable = True
        '
        'tgShowTodayLiveGamesFirst
        '
        Me.tgShowTodayLiveGamesFirst.AutoSize = True
        Me.tgShowTodayLiveGamesFirst.Location = New System.Drawing.Point(3, 3)
        Me.tgShowTodayLiveGamesFirst.Name = "tgShowTodayLiveGamesFirst"
        Me.tgShowTodayLiveGamesFirst.Size = New System.Drawing.Size(80, 19)
        Me.tgShowTodayLiveGamesFirst.Style = MetroFramework.MetroColorStyle.Red
        Me.tgShowTodayLiveGamesFirst.TabIndex = 8
        Me.tgShowTodayLiveGamesFirst.Text = "Off"
        Me.tgShowTodayLiveGamesFirst.UseSelectable = True
        '
        'lblShowTodayLiveGamesFirst
        '
        Me.lblShowTodayLiveGamesFirst.AutoSize = True
        Me.lblShowTodayLiveGamesFirst.Location = New System.Drawing.Point(89, 0)
        Me.lblShowTodayLiveGamesFirst.Name = "lblShowTodayLiveGamesFirst"
        Me.lblShowTodayLiveGamesFirst.Size = New System.Drawing.Size(214, 19)
        Me.lblShowTodayLiveGamesFirst.Style = MetroFramework.MetroColorStyle.Red
        Me.lblShowTodayLiveGamesFirst.TabIndex = 9
        Me.lblShowTodayLiveGamesFirst.Text = "SHOW_TODAY_LIVE_GAMES_FIRST"
        '
        'lblShowTeamCityAbr
        '
        Me.lblShowTeamCityAbr.AutoSize = True
        Me.lblShowTeamCityAbr.Location = New System.Drawing.Point(465, 30)
        Me.lblShowTeamCityAbr.Name = "lblShowTeamCityAbr"
        Me.lblShowTeamCityAbr.Size = New System.Drawing.Size(218, 19)
        Me.lblShowTeamCityAbr.Style = MetroFramework.MetroColorStyle.Red
        Me.lblShowTeamCityAbr.TabIndex = 7
        Me.lblShowTeamCityAbr.Text = "SHOW_TEAM_CITY_ABBREVIATION"
        '
        'tgShowTeamCityAbr
        '
        Me.tgShowTeamCityAbr.AutoSize = True
        Me.tgShowTeamCityAbr.Location = New System.Drawing.Point(382, 30)
        Me.tgShowTeamCityAbr.Margin = New System.Windows.Forms.Padding(0)
        Me.tgShowTeamCityAbr.Name = "tgShowTeamCityAbr"
        Me.tgShowTeamCityAbr.Size = New System.Drawing.Size(80, 19)
        Me.tgShowTeamCityAbr.Style = MetroFramework.MetroColorStyle.Red
        Me.tgShowTeamCityAbr.TabIndex = 6
        Me.tgShowTeamCityAbr.Text = "Off"
        Me.tgShowTeamCityAbr.UseSelectable = True
        '
        'lblShowLiveScores
        '
        Me.lblShowLiveScores.AutoSize = True
        Me.lblShowLiveScores.Location = New System.Drawing.Point(89, 60)
        Me.lblShowLiveScores.Name = "lblShowLiveScores"
        Me.lblShowLiveScores.Size = New System.Drawing.Size(134, 19)
        Me.lblShowLiveScores.Style = MetroFramework.MetroColorStyle.Red
        Me.lblShowLiveScores.TabIndex = 1
        Me.lblShowLiveScores.Text = "SHOW_LIVE_SCORES"
        Me.lblShowLiveScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tgShowLiveScores
        '
        Me.tgShowLiveScores.AutoSize = True
        Me.tgShowLiveScores.Location = New System.Drawing.Point(3, 63)
        Me.tgShowLiveScores.Name = "tgShowLiveScores"
        Me.tgShowLiveScores.Size = New System.Drawing.Size(80, 19)
        Me.tgShowLiveScores.Style = MetroFramework.MetroColorStyle.Red
        Me.tgShowLiveScores.TabIndex = 4
        Me.tgShowLiveScores.Text = "Off"
        Me.tgShowLiveScores.UseSelectable = True
        '
        'lblShowSeriesRecord
        '
        Me.lblShowSeriesRecord.AutoSize = True
        Me.lblShowSeriesRecord.Location = New System.Drawing.Point(465, 0)
        Me.lblShowSeriesRecord.Name = "lblShowSeriesRecord"
        Me.lblShowSeriesRecord.Size = New System.Drawing.Size(152, 19)
        Me.lblShowSeriesRecord.Style = MetroFramework.MetroColorStyle.Red
        Me.lblShowSeriesRecord.TabIndex = 2
        Me.lblShowSeriesRecord.Text = "SHOW_SERIES_RECORD"
        Me.lblShowSeriesRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShowFinalScores
        '
        Me.lblShowFinalScores.AutoSize = True
        Me.lblShowFinalScores.Location = New System.Drawing.Point(465, 60)
        Me.lblShowFinalScores.Name = "lblShowFinalScores"
        Me.lblShowFinalScores.Size = New System.Drawing.Size(145, 19)
        Me.lblShowFinalScores.Style = MetroFramework.MetroColorStyle.Red
        Me.lblShowFinalScores.TabIndex = 0
        Me.lblShowFinalScores.Text = "SHOW_FINAL_SCORES"
        Me.lblShowFinalScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tgShowFinalScores
        '
        Me.tgShowFinalScores.AutoSize = True
        Me.tgShowFinalScores.Location = New System.Drawing.Point(382, 60)
        Me.tgShowFinalScores.Margin = New System.Windows.Forms.Padding(0)
        Me.tgShowFinalScores.Name = "tgShowFinalScores"
        Me.tgShowFinalScores.Size = New System.Drawing.Size(80, 19)
        Me.tgShowFinalScores.Style = MetroFramework.MetroColorStyle.Red
        Me.tgShowFinalScores.TabIndex = 3
        Me.tgShowFinalScores.Text = "Off"
        Me.tgShowFinalScores.UseSelectable = True
        '
        'tgShowSeriesRecord
        '
        Me.tgShowSeriesRecord.AutoSize = True
        Me.tgShowSeriesRecord.Location = New System.Drawing.Point(382, 0)
        Me.tgShowSeriesRecord.Margin = New System.Windows.Forms.Padding(0)
        Me.tgShowSeriesRecord.Name = "tgShowSeriesRecord"
        Me.tgShowSeriesRecord.Size = New System.Drawing.Size(80, 19)
        Me.tgShowSeriesRecord.Style = MetroFramework.MetroColorStyle.Red
        Me.tgShowSeriesRecord.TabIndex = 5
        Me.tgShowSeriesRecord.Text = "Off"
        Me.tgShowSeriesRecord.UseSelectable = True
        '
        'tgShowLiveTime
        '
        Me.tgShowLiveTime.AutoSize = True
        Me.tgShowLiveTime.Location = New System.Drawing.Point(3, 33)
        Me.tgShowLiveTime.Name = "tgShowLiveTime"
        Me.tgShowLiveTime.Size = New System.Drawing.Size(80, 19)
        Me.tgShowLiveTime.Style = MetroFramework.MetroColorStyle.Red
        Me.tgShowLiveTime.TabIndex = 10
        Me.tgShowLiveTime.Text = "Off"
        Me.tgShowLiveTime.UseSelectable = True
        '
        'lblShowLiveTime
        '
        Me.lblShowLiveTime.AutoSize = True
        Me.lblShowLiveTime.Location = New System.Drawing.Point(89, 30)
        Me.lblShowLiveTime.Name = "lblShowLiveTime"
        Me.lblShowLiveTime.Size = New System.Drawing.Size(114, 19)
        Me.lblShowLiveTime.Style = MetroFramework.MetroColorStyle.Red
        Me.lblShowLiveTime.TabIndex = 11
        Me.lblShowLiveTime.Text = "SHOW_LIVE_TIME"
        '
        'lblShowStanding
        '
        Me.lblShowStanding.AutoSize = True
        Me.lblShowStanding.Location = New System.Drawing.Point(89, 90)
        Me.lblShowStanding.Name = "lblShowStanding"
        Me.lblShowStanding.Size = New System.Drawing.Size(117, 19)
        Me.lblShowStanding.Style = MetroFramework.MetroColorStyle.Red
        Me.lblShowStanding.TabIndex = 13
        Me.lblShowStanding.Text = "SHOW_STANDING"
        Me.lblShowStanding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPlayer.Location = New System.Drawing.Point(42, 420)
        Me.lblPlayer.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(112, 30)
        Me.lblPlayer.Style = MetroFramework.MetroColorStyle.Red
        Me.lblPlayer.TabIndex = 3
        Me.lblPlayer.Text = "DEFAULT_PLAYER"
        Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flpSelectedPlayer
        '
        Me.flpSelectedPlayer.Controls.Add(Me.rbMPV)
        Me.flpSelectedPlayer.Controls.Add(Me.lblMPVLogo)
        Me.flpSelectedPlayer.Controls.Add(Me.rbVLC)
        Me.flpSelectedPlayer.Controls.Add(Me.lblVLCLogo)
        Me.flpSelectedPlayer.Controls.Add(Me.rbMPC)
        Me.flpSelectedPlayer.Controls.Add(Me.lvlMPCHCLogo)
        Me.flpSelectedPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpSelectedPlayer.Location = New System.Drawing.Point(174, 420)
        Me.flpSelectedPlayer.Margin = New System.Windows.Forms.Padding(0)
        Me.flpSelectedPlayer.Name = "flpSelectedPlayer"
        Me.flpSelectedPlayer.Size = New System.Drawing.Size(771, 30)
        Me.flpSelectedPlayer.TabIndex = 513
        '
        'rbMPV
        '
        Me.rbMPV.Enabled = False
        Me.rbMPV.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rbMPV.Location = New System.Drawing.Point(3, 3)
        Me.rbMPV.Name = "rbMPV"
        Me.rbMPV.Size = New System.Drawing.Size(60, 21)
        Me.rbMPV.Style = MetroFramework.MetroColorStyle.Red
        Me.rbMPV.TabIndex = 2
        Me.rbMPV.Text = "MPV"
        Me.rbMPV.UseSelectable = True
        '
        'lblMPVLogo
        '
        Me.lblMPVLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblMPVLogo.Location = New System.Drawing.Point(66, 0)
        Me.lblMPVLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMPVLogo.Name = "lblMPVLogo"
        Me.lblMPVLogo.Padding = New System.Windows.Forms.Padding(3)
        Me.lblMPVLogo.Size = New System.Drawing.Size(27, 27)
        Me.lblMPVLogo.TabIndex = 5
        '
        'rbVLC
        '
        Me.rbVLC.Enabled = False
        Me.rbVLC.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rbVLC.Location = New System.Drawing.Point(146, 3)
        Me.rbVLC.Margin = New System.Windows.Forms.Padding(53, 3, 3, 3)
        Me.rbVLC.Name = "rbVLC"
        Me.rbVLC.Size = New System.Drawing.Size(60, 21)
        Me.rbVLC.Style = MetroFramework.MetroColorStyle.Red
        Me.rbVLC.TabIndex = 0
        Me.rbVLC.Text = "VLC"
        Me.rbVLC.UseSelectable = True
        '
        'lblVLCLogo
        '
        Me.lblVLCLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblVLCLogo.Location = New System.Drawing.Point(209, 0)
        Me.lblVLCLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVLCLogo.Name = "lblVLCLogo"
        Me.lblVLCLogo.Padding = New System.Windows.Forms.Padding(3)
        Me.lblVLCLogo.Size = New System.Drawing.Size(27, 27)
        Me.lblVLCLogo.TabIndex = 3
        '
        'rbMPC
        '
        Me.rbMPC.Enabled = False
        Me.rbMPC.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rbMPC.Location = New System.Drawing.Point(289, 3)
        Me.rbMPC.Margin = New System.Windows.Forms.Padding(53, 3, 3, 3)
        Me.rbMPC.Name = "rbMPC"
        Me.rbMPC.Size = New System.Drawing.Size(86, 21)
        Me.rbMPC.Style = MetroFramework.MetroColorStyle.Red
        Me.rbMPC.TabIndex = 1
        Me.rbMPC.Text = "MPC-HC"
        Me.rbMPC.UseSelectable = True
        '
        'lvlMPCHCLogo
        '
        Me.lvlMPCHCLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvlMPCHCLogo.Location = New System.Drawing.Point(378, 0)
        Me.lvlMPCHCLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.lvlMPCHCLogo.Name = "lvlMPCHCLogo"
        Me.lvlMPCHCLogo.Padding = New System.Windows.Forms.Padding(3)
        Me.lvlMPCHCLogo.Size = New System.Drawing.Size(27, 27)
        Me.lvlMPCHCLogo.TabIndex = 4
        '
        'tlpCdnSettings
        '
        Me.tlpCdnSettings.ColumnCount = 2
        Me.tlpCdnSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpCdnSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCdnSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCdnSettings.Controls.Add(Me.tgAlternateCdn, 0, 0)
        Me.tlpCdnSettings.Controls.Add(Me.lblUseAlternateCdn, 1, 0)
        Me.tlpCdnSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCdnSettings.Location = New System.Drawing.Point(174, 300)
        Me.tlpCdnSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCdnSettings.Name = "tlpCdnSettings"
        Me.tlpCdnSettings.RowCount = 1
        Me.tlpCdnSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCdnSettings.Size = New System.Drawing.Size(771, 30)
        Me.tlpCdnSettings.TabIndex = 514
        '
        'tgAlternateCdn
        '
        Me.tgAlternateCdn.AutoSize = True
        Me.tgAlternateCdn.Location = New System.Drawing.Point(3, 6)
        Me.tgAlternateCdn.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.tgAlternateCdn.Name = "tgAlternateCdn"
        Me.tgAlternateCdn.Size = New System.Drawing.Size(80, 19)
        Me.tgAlternateCdn.Style = MetroFramework.MetroColorStyle.Red
        Me.tgAlternateCdn.TabIndex = 0
        Me.tgAlternateCdn.Text = "Off"
        Me.tgAlternateCdn.UseSelectable = True
        '
        'lblUseAlternateCdn
        '
        Me.lblUseAlternateCdn.AutoSize = True
        Me.lblUseAlternateCdn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUseAlternateCdn.Location = New System.Drawing.Point(89, 0)
        Me.lblUseAlternateCdn.Name = "lblUseAlternateCdn"
        Me.lblUseAlternateCdn.Size = New System.Drawing.Size(679, 30)
        Me.lblUseAlternateCdn.Style = MetroFramework.MetroColorStyle.Red
        Me.lblUseAlternateCdn.TabIndex = 1
        Me.lblUseAlternateCdn.Text = "USE_ALTERNATE_NETWORK"
        Me.lblUseAlternateCdn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMedia.Location = New System.Drawing.Point(71, 903)
        Me.lblMedia.Margin = New System.Windows.Forms.Padding(3)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(80, 24)
        Me.lblMedia.Style = MetroFramework.MetroColorStyle.Red
        Me.lblMedia.TabIndex = 72
        Me.lblMedia.Text = "MEDIA_APP"
        '
        'lblOBS
        '
        Me.lblOBS.AutoSize = True
        Me.lblOBS.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblOBS.Location = New System.Drawing.Point(3, 963)
        Me.lblOBS.Margin = New System.Windows.Forms.Padding(3)
        Me.lblOBS.Name = "lblOBS"
        Me.lblOBS.Size = New System.Drawing.Size(148, 24)
        Me.lblOBS.Style = MetroFramework.MetroColorStyle.Red
        Me.lblOBS.TabIndex = 73
        Me.lblOBS.Text = "OBS_SCENE_CHANGER"
        Me.lblOBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flpSpotifyParameters
        '
        Me.flpSpotifyParameters.Controls.Add(Me.chkSpotifyPlayNextSong)
        Me.flpSpotifyParameters.Controls.Add(Me.chkSpotifyHotkeys)
        Me.flpSpotifyParameters.Controls.Add(Me.chkSpotifyForceToStart)
        Me.flpSpotifyParameters.Controls.Add(Me.FlowLayoutPanel1)
        Me.flpSpotifyParameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpSpotifyParameters.Enabled = False
        Me.flpSpotifyParameters.Location = New System.Drawing.Point(174, 930)
        Me.flpSpotifyParameters.Margin = New System.Windows.Forms.Padding(0)
        Me.flpSpotifyParameters.Name = "flpSpotifyParameters"
        Me.flpSpotifyParameters.Size = New System.Drawing.Size(771, 30)
        Me.flpSpotifyParameters.TabIndex = 79
        '
        'chkSpotifyPlayNextSong
        '
        Me.chkSpotifyPlayNextSong.AutoSize = True
        Me.chkSpotifyPlayNextSong.Location = New System.Drawing.Point(6, 6)
        Me.chkSpotifyPlayNextSong.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpotifyPlayNextSong.Name = "chkSpotifyPlayNextSong"
        Me.chkSpotifyPlayNextSong.Size = New System.Drawing.Size(120, 15)
        Me.chkSpotifyPlayNextSong.Style = MetroFramework.MetroColorStyle.Red
        Me.chkSpotifyPlayNextSong.TabIndex = 78
        Me.chkSpotifyPlayNextSong.Text = "PLAY_NEXT_SONG"
        Me.chkSpotifyPlayNextSong.UseSelectable = True
        '
        'chkSpotifyHotkeys
        '
        Me.chkSpotifyHotkeys.AutoSize = True
        Me.chkSpotifyHotkeys.Location = New System.Drawing.Point(138, 6)
        Me.chkSpotifyHotkeys.Margin = New System.Windows.Forms.Padding(6)
        Me.chkSpotifyHotkeys.Name = "chkSpotifyHotkeys"
        Me.chkSpotifyHotkeys.Size = New System.Drawing.Size(145, 15)
        Me.chkSpotifyHotkeys.Style = MetroFramework.MetroColorStyle.Red
        Me.chkSpotifyHotkeys.TabIndex = 79
        Me.chkSpotifyHotkeys.Text = "USE_SPOTIFY_HOTKEYS"
        Me.chkSpotifyHotkeys.UseSelectable = True
        '
        'chkSpotifyForceToStart
        '
        Me.chkSpotifyForceToStart.AutoSize = True
        Me.chkSpotifyForceToStart.Location = New System.Drawing.Point(301, 6)
        Me.chkSpotifyForceToStart.Margin = New System.Windows.Forms.Padding(12, 6, 6, 6)
        Me.chkSpotifyForceToStart.Name = "chkSpotifyForceToStart"
        Me.chkSpotifyForceToStart.Size = New System.Drawing.Size(162, 15)
        Me.chkSpotifyForceToStart.Style = MetroFramework.MetroColorStyle.Red
        Me.chkSpotifyForceToStart.TabIndex = 77
        Me.chkSpotifyForceToStart.Text = "FORCE_SPOTIFY_TO_START"
        Me.chkSpotifyForceToStart.UseSelectable = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.lblMediaControlDelay)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtMediaControlDelay)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblMediaControlDelayMs)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(479, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(225, 29)
        Me.FlowLayoutPanel1.TabIndex = 531
        '
        'lblMediaControlDelay
        '
        Me.lblMediaControlDelay.AutoSize = True
        Me.lblMediaControlDelay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMediaControlDelay.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblMediaControlDelay.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblMediaControlDelay.Location = New System.Drawing.Point(3, 3)
        Me.lblMediaControlDelay.Margin = New System.Windows.Forms.Padding(3)
        Me.lblMediaControlDelay.Name = "lblMediaControlDelay"
        Me.lblMediaControlDelay.Size = New System.Drawing.Size(141, 23)
        Me.lblMediaControlDelay.Style = MetroFramework.MetroColorStyle.Red
        Me.lblMediaControlDelay.TabIndex = 530
        Me.lblMediaControlDelay.Text = "MEDIA_CONTROL_DELAY"
        Me.lblMediaControlDelay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMediaControlDelay
        '
        '
        '
        '
        Me.txtMediaControlDelay.CustomButton.Image = Nothing
        Me.txtMediaControlDelay.CustomButton.Location = New System.Drawing.Point(22, 1)
        Me.txtMediaControlDelay.CustomButton.Name = ""
        Me.txtMediaControlDelay.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMediaControlDelay.CustomButton.Style = MetroFramework.MetroColorStyle.Red
        Me.txtMediaControlDelay.CustomButton.TabIndex = 1
        Me.txtMediaControlDelay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMediaControlDelay.CustomButton.UseSelectable = True
        Me.txtMediaControlDelay.CustomButton.Visible = False
        Me.txtMediaControlDelay.Lines = New String(-1) {}
        Me.txtMediaControlDelay.Location = New System.Drawing.Point(150, 3)
        Me.txtMediaControlDelay.MaxLength = 5
        Me.txtMediaControlDelay.Name = "txtMediaControlDelay"
        Me.txtMediaControlDelay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMediaControlDelay.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMediaControlDelay.SelectedText = ""
        Me.txtMediaControlDelay.SelectionLength = 0
        Me.txtMediaControlDelay.SelectionStart = 0
        Me.txtMediaControlDelay.ShortcutsEnabled = True
        Me.txtMediaControlDelay.Size = New System.Drawing.Size(44, 23)
        Me.txtMediaControlDelay.Style = MetroFramework.MetroColorStyle.Red
        Me.txtMediaControlDelay.TabIndex = 528
        Me.txtMediaControlDelay.UseSelectable = True
        Me.txtMediaControlDelay.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMediaControlDelay.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblMediaControlDelayMs
        '
        Me.lblMediaControlDelayMs.AutoSize = True
        Me.lblMediaControlDelayMs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMediaControlDelayMs.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblMediaControlDelayMs.Location = New System.Drawing.Point(200, 3)
        Me.lblMediaControlDelayMs.Margin = New System.Windows.Forms.Padding(3)
        Me.lblMediaControlDelayMs.Name = "lblMediaControlDelayMs"
        Me.lblMediaControlDelayMs.Size = New System.Drawing.Size(22, 23)
        Me.lblMediaControlDelayMs.Style = MetroFramework.MetroColorStyle.Red
        Me.lblMediaControlDelayMs.TabIndex = 529
        Me.lblMediaControlDelayMs.Text = "ms"
        Me.lblMediaControlDelayMs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblModules
        '
        Me.lblModules.AutoSize = True
        Me.lblModules.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblModules.Location = New System.Drawing.Point(48, 870)
        Me.lblModules.Name = "lblModules"
        Me.lblModules.Size = New System.Drawing.Size(103, 30)
        Me.lblModules.Style = MetroFramework.MetroColorStyle.Red
        Me.lblModules.TabIndex = 515
        Me.lblModules.Text = "AD_DETECTION"
        '
        'flpAdDetection
        '
        Me.flpAdDetection.Controls.Add(Me.tgModules)
        Me.flpAdDetection.Controls.Add(Me.lblModulesDesc)
        Me.flpAdDetection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpAdDetection.Location = New System.Drawing.Point(174, 870)
        Me.flpAdDetection.Margin = New System.Windows.Forms.Padding(0)
        Me.flpAdDetection.Name = "flpAdDetection"
        Me.flpAdDetection.Size = New System.Drawing.Size(771, 30)
        Me.flpAdDetection.TabIndex = 517
        '
        'tgModules
        '
        Me.tgModules.AutoSize = True
        Me.tgModules.Location = New System.Drawing.Point(3, 3)
        Me.tgModules.Name = "tgModules"
        Me.tgModules.Size = New System.Drawing.Size(80, 19)
        Me.tgModules.Style = MetroFramework.MetroColorStyle.Red
        Me.tgModules.TabIndex = 516
        Me.tgModules.Text = "Off"
        Me.tgModules.UseSelectable = True
        '
        'lblModulesDesc
        '
        Me.lblModulesDesc.AutoSize = True
        Me.lblModulesDesc.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblModulesDesc.Location = New System.Drawing.Point(91, 5)
        Me.lblModulesDesc.Margin = New System.Windows.Forms.Padding(5)
        Me.lblModulesDesc.Name = "lblModulesDesc"
        Me.lblModulesDesc.Size = New System.Drawing.Size(120, 15)
        Me.lblModulesDesc.Style = MetroFramework.MetroColorStyle.Red
        Me.lblModulesDesc.TabIndex = 517
        Me.lblModulesDesc.Text = "AD_DETECTION_DESC"
        Me.lblModulesDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpReplay
        '
        Me.tlpReplay.ColumnCount = 2
        Me.tlpReplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.tlpReplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpReplay.Controls.Add(Me.lblLiveRewindDetails, 1, 0)
        Me.tlpReplay.Controls.Add(Me.tbLiveRewind, 0, 0)
        Me.tlpReplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpReplay.Location = New System.Drawing.Point(174, 240)
        Me.tlpReplay.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpReplay.Name = "tlpReplay"
        Me.tlpReplay.RowCount = 1
        Me.tlpReplay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpReplay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpReplay.Size = New System.Drawing.Size(771, 30)
        Me.tlpReplay.TabIndex = 519
        '
        'lblLiveRewindDetails
        '
        Me.lblLiveRewindDetails.AutoSize = True
        Me.lblLiveRewindDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLiveRewindDetails.Location = New System.Drawing.Point(350, 0)
        Me.lblLiveRewindDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLiveRewindDetails.Name = "lblLiveRewindDetails"
        Me.lblLiveRewindDetails.Size = New System.Drawing.Size(421, 30)
        Me.lblLiveRewindDetails.Style = MetroFramework.MetroColorStyle.Red
        Me.lblLiveRewindDetails.TabIndex = 1
        Me.lblLiveRewindDetails.Text = "00_MINUTES_BEHIND_LIVE"
        Me.lblLiveRewindDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLiveRewind
        '
        Me.lblLiveRewind.AutoSize = True
        Me.lblLiveRewind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLiveRewind.Location = New System.Drawing.Point(3, 240)
        Me.lblLiveRewind.Name = "lblLiveRewind"
        Me.lblLiveRewind.Size = New System.Drawing.Size(148, 30)
        Me.lblLiveRewind.Style = MetroFramework.MetroColorStyle.Red
        Me.lblLiveRewind.TabIndex = 520
        Me.lblLiveRewind.Text = "REWIND_LIVE_STREAM"
        Me.lblLiveRewind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCdn
        '
        Me.lblCdn.AutoSize = True
        Me.lblCdn.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblCdn.Location = New System.Drawing.Point(117, 300)
        Me.lblCdn.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCdn.Name = "lblCdn"
        Me.lblCdn.Size = New System.Drawing.Size(37, 30)
        Me.lblCdn.Style = MetroFramework.MetroColorStyle.Red
        Me.lblCdn.TabIndex = 3
        Me.lblCdn.Text = "CDN"
        Me.lblCdn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLiveReplay
        '
        Me.lblLiveReplay.AutoSize = True
        Me.lblLiveReplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLiveReplay.Location = New System.Drawing.Point(3, 210)
        Me.lblLiveReplay.Name = "lblLiveReplay"
        Me.lblLiveReplay.Size = New System.Drawing.Size(148, 30)
        Me.lblLiveReplay.Style = MetroFramework.MetroColorStyle.Red
        Me.lblLiveReplay.TabIndex = 521
        Me.lblLiveReplay.Text = "REPLAY_LIVE_STREAM"
        Me.lblLiveReplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tgDarkMode
        '
        Me.tgDarkMode.AutoSize = True
        Me.tgDarkMode.Location = New System.Drawing.Point(177, 603)
        Me.tgDarkMode.Name = "tgDarkMode"
        Me.tgDarkMode.Size = New System.Drawing.Size(80, 19)
        Me.tgDarkMode.Style = MetroFramework.MetroColorStyle.Red
        Me.tgDarkMode.TabIndex = 523
        Me.tgDarkMode.Text = "Off"
        Me.tgDarkMode.UseSelectable = True
        '
        'lblDarkMode
        '
        Me.lblDarkMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDarkMode.Location = New System.Drawing.Point(3, 600)
        Me.lblDarkMode.Name = "lblDarkMode"
        Me.lblDarkMode.Size = New System.Drawing.Size(148, 30)
        Me.lblDarkMode.Style = MetroFramework.MetroColorStyle.Red
        Me.lblDarkMode.TabIndex = 524
        Me.lblDarkMode.Text = "DARK"
        Me.lblDarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReset.Location = New System.Drawing.Point(3, 1080)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(148, 30)
        Me.lblReset.Style = MetroFramework.MetroColorStyle.Red
        Me.lblReset.TabIndex = 525
        Me.lblReset.Text = "RESET"
        Me.lblReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.tgReset)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblResetDesc)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(174, 1080)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(771, 30)
        Me.FlowLayoutPanel2.TabIndex = 528
        '
        'tgReset
        '
        Me.tgReset.AutoSize = True
        Me.tgReset.Location = New System.Drawing.Point(3, 3)
        Me.tgReset.Name = "tgReset"
        Me.tgReset.Size = New System.Drawing.Size(80, 19)
        Me.tgReset.Style = MetroFramework.MetroColorStyle.Red
        Me.tgReset.TabIndex = 526
        Me.tgReset.Text = "Off"
        Me.tgReset.UseSelectable = True
        '
        'lblResetDesc
        '
        Me.lblResetDesc.AutoSize = True
        Me.lblResetDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResetDesc.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblResetDesc.Location = New System.Drawing.Point(91, 5)
        Me.lblResetDesc.Margin = New System.Windows.Forms.Padding(5)
        Me.lblResetDesc.Name = "lblResetDesc"
        Me.lblResetDesc.Size = New System.Drawing.Size(70, 15)
        Me.lblResetDesc.Style = MetroFramework.MetroColorStyle.Red
        Me.lblResetDesc.TabIndex = 527
        Me.lblResetDesc.Text = "RESET_DESC"
        Me.lblResetDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabConsole
        '
        Me.tabConsole.Controls.Add(Me.btnCopyConsole)
        Me.tabConsole.Controls.Add(Me.btnClearConsole)
        Me.tabConsole.Controls.Add(Me.txtConsole)
        Me.tabConsole.HorizontalScrollbarBarColor = False
        Me.tabConsole.HorizontalScrollbarHighlightOnWheel = False
        Me.tabConsole.HorizontalScrollbarSize = 10
        Me.tabConsole.Location = New System.Drawing.Point(4, 38)
        Me.tabConsole.Name = "tabConsole"
        Me.tabConsole.Size = New System.Drawing.Size(984, 508)
        Me.tabConsole.TabIndex = 2
        Me.tabConsole.Text = "CONSOLE"
        Me.tabConsole.UseCustomForeColor = True
        Me.tabConsole.VerticalScrollbarBarColor = False
        Me.tabConsole.VerticalScrollbarHighlightOnWheel = False
        Me.tabConsole.VerticalScrollbarSize = 10
        '
        'btnCopyConsole
        '
        Me.btnCopyConsole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopyConsole.Location = New System.Drawing.Point(635, 489)
        Me.btnCopyConsole.Name = "btnCopyConsole"
        Me.btnCopyConsole.Size = New System.Drawing.Size(200, 23)
        Me.btnCopyConsole.Style = MetroFramework.MetroColorStyle.Red
        Me.btnCopyConsole.TabIndex = 120
        Me.btnCopyConsole.Text = "COPY_TO_CLIPBOARD"
        Me.btnCopyConsole.UseSelectable = True
        '
        'btnClearConsole
        '
        Me.btnClearConsole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearConsole.Location = New System.Drawing.Point(841, 489)
        Me.btnClearConsole.Name = "btnClearConsole"
        Me.btnClearConsole.Size = New System.Drawing.Size(139, 23)
        Me.btnClearConsole.Style = MetroFramework.MetroColorStyle.Red
        Me.btnClearConsole.TabIndex = 130
        Me.btnClearConsole.Text = "CLEAR"
        Me.btnClearConsole.UseSelectable = True
        '
        'tmr
        '
        '
        'tt
        '
        Me.tt.Style = MetroFramework.MetroColorStyle.Red
        Me.tt.StyleManager = Nothing
        Me.tt.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'pnlBottom
        '
        Me.pnlBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlBottom.Controls.Add(Me.tlpStatus)
        Me.pnlBottom.HorizontalScrollbarBarColor = True
        Me.pnlBottom.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlBottom.HorizontalScrollbarSize = 10
        Me.pnlBottom.Location = New System.Drawing.Point(3, 614)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(984, 38)
        Me.pnlBottom.TabIndex = 27
        Me.pnlBottom.UseCustomBackColor = True
        Me.pnlBottom.VerticalScrollbarBarColor = False
        Me.pnlBottom.VerticalScrollbarHighlightOnWheel = False
        Me.pnlBottom.VerticalScrollbarSize = 10
        '
        'tlpStatus
        '
        Me.tlpStatus.ColumnCount = 4
        Me.tlpStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpStatus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpStatus.Controls.Add(Me.lblStatus, 3, 0)
        Me.tlpStatus.Controls.Add(Me.lblVersion, 0, 0)
        Me.tlpStatus.Controls.Add(Me.lnkReddit, 1, 0)
        Me.tlpStatus.Controls.Add(Me.TableLayoutPanel1, 2, 0)
        Me.tlpStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpStatus.Location = New System.Drawing.Point(0, 0)
        Me.tlpStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpStatus.Name = "tlpStatus"
        Me.tlpStatus.RowCount = 1
        Me.tlpStatus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpStatus.Size = New System.Drawing.Size(984, 38)
        Me.tlpStatus.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(936, 0)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 38)
        Me.lblStatus.Style = MetroFramework.MetroColorStyle.Red
        Me.lblStatus.TabIndex = 26
        Me.lblStatus.Text = "STATUS"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblStatus.UseCustomBackColor = True
        Me.lblStatus.UseCustomForeColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblVersion.Location = New System.Drawing.Point(0, 0)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(54, 38)
        Me.lblVersion.Style = MetroFramework.MetroColorStyle.Red
        Me.lblVersion.TabIndex = 62
        Me.lblVersion.Text = "VERSION"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVersion.UseCustomBackColor = True
        Me.lblVersion.UseCustomForeColor = True
        '
        'lnkReddit
        '
        Me.lnkReddit.AutoSize = True
        Me.lnkReddit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkReddit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkReddit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkReddit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lnkReddit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkReddit.Location = New System.Drawing.Point(63, 0)
        Me.lnkReddit.Margin = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.lnkReddit.Name = "lnkReddit"
        Me.lnkReddit.Size = New System.Drawing.Size(92, 38)
        Me.lnkReddit.Style = MetroFramework.MetroColorStyle.Red
        Me.lnkReddit.TabIndex = 20
        Me.lnkReddit.Text = "/r/mlb_games"
        Me.lnkReddit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkReddit.UseCustomBackColor = True
        Me.lnkReddit.UseSelectable = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lblTip, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lnkRelease, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(173, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(740, 38)
        Me.TableLayoutPanel1.TabIndex = 63
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTip.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblTip.Location = New System.Drawing.Point(0, 0)
        Me.lblTip.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(23, 38)
        Me.lblTip.Style = MetroFramework.MetroColorStyle.Red
        Me.lblTip.TabIndex = 62
        Me.lblTip.Text = "TIP"
        Me.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTip.UseCustomBackColor = True
        Me.lblTip.UseCustomForeColor = True
        '
        'lnkRelease
        '
        Me.lnkRelease.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkRelease.AutoSize = True
        Me.lnkRelease.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkRelease.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkRelease.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lnkRelease.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkRelease.Location = New System.Drawing.Point(23, 0)
        Me.lnkRelease.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkRelease.Name = "lnkRelease"
        Me.lnkRelease.Size = New System.Drawing.Size(717, 38)
        Me.lnkRelease.Style = MetroFramework.MetroColorStyle.Red
        Me.lnkRelease.TabIndex = 20
        Me.lnkRelease.Text = "RELEASE"
        Me.lnkRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkRelease.UseCustomBackColor = True
        Me.lnkRelease.UseCustomForeColor = True
        Me.lnkRelease.UseSelectable = True
        Me.lnkRelease.Visible = False
        '
        'spnStreaming
        '
        Me.spnStreaming.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spnStreaming.BackColor = System.Drawing.Color.Magenta
        Me.spnStreaming.Location = New System.Drawing.Point(915, 46)
        Me.spnStreaming.Maximum = 1000
        Me.spnStreaming.Name = "spnStreaming"
        Me.spnStreaming.Size = New System.Drawing.Size(50, 50)
        Me.spnStreaming.Speed = 2.0!
        Me.spnStreaming.Style = MetroFramework.MetroColorStyle.Red
        Me.spnStreaming.TabIndex = 4
        Me.spnStreaming.UseSelectable = True
        Me.spnStreaming.Value = 1000
        Me.spnStreaming.Visible = False
        '
        'bw
        '
        Me.bw.WorkerReportsProgress = True
        Me.bw.WorkerSupportsCancellation = True
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.btnHelp.ImageSize = 12
        Me.btnHelp.Location = New System.Drawing.Point(890, 5)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(20, 20)
        Me.btnHelp.Style = MetroFramework.MetroColorStyle.Red
        Me.btnHelp.TabIndex = 9999
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseSelectable = True
        '
        'pnlLogo
        '
        Me.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlLogo.Location = New System.Drawing.Point(10, 15)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(212, 50)
        Me.pnlLogo.TabIndex = 10000
        '
        'cbSeasons
        '
        Me.cbSeasons.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbSeasons.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbSeasons.FormattingEnabled = True
        Me.cbSeasons.IntegralHeight = False
        Me.cbSeasons.ItemHeight = 19
        Me.cbSeasons.Location = New System.Drawing.Point(103, 33)
        Me.cbSeasons.Name = "cbSeasons"
        Me.cbSeasons.Size = New System.Drawing.Size(200, 25)
        Me.cbSeasons.Style = MetroFramework.MetroColorStyle.Red
        Me.cbSeasons.TabIndex = 501
        Me.cbSeasons.UseSelectable = True
        '
        'cbStreamQuality
        '
        Me.cbStreamQuality.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbStreamQuality.DropDownHeight = 200
        Me.cbStreamQuality.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbStreamQuality.FormattingEnabled = True
        Me.cbStreamQuality.IntegralHeight = False
        Me.cbStreamQuality.ItemHeight = 19
        Me.cbStreamQuality.Location = New System.Drawing.Point(177, 183)
        Me.cbStreamQuality.Name = "cbStreamQuality"
        Me.cbStreamQuality.Size = New System.Drawing.Size(600, 25)
        Me.cbStreamQuality.Style = MetroFramework.MetroColorStyle.Red
        Me.cbStreamQuality.TabIndex = 500
        Me.cbStreamQuality.UseSelectable = True
        '
        'cbLanguage
        '
        Me.cbLanguage.BackColor = System.Drawing.SystemColors.Window
        Me.cbLanguage.DropDownHeight = 80
        Me.cbLanguage.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbLanguage.FormattingEnabled = True
        Me.cbLanguage.IntegralHeight = False
        Me.cbLanguage.ItemHeight = 19
        Me.cbLanguage.Location = New System.Drawing.Point(3, 3)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(600, 25)
        Me.cbLanguage.Style = MetroFramework.MetroColorStyle.Red
        Me.cbLanguage.TabIndex = 1410
        Me.cbLanguage.UseSelectable = True
        '
        'cbServers
        '
        Me.cbServers.BackColor = System.Drawing.SystemColors.Window
        Me.cbServers.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbServers.DropDownHeight = 80
        Me.cbServers.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbServers.FormattingEnabled = True
        Me.cbServers.IntegralHeight = False
        Me.cbServers.ItemHeight = 19
        Me.cbServers.Location = New System.Drawing.Point(177, 333)
        Me.cbServers.Name = "cbServers"
        Me.cbServers.Size = New System.Drawing.Size(600, 25)
        Me.cbServers.Style = MetroFramework.MetroColorStyle.Red
        Me.cbServers.TabIndex = 510
        Me.cbServers.UseSelectable = True
        '
        'tbProxyPort
        '
        Me.tbProxyPort.BackColor = System.Drawing.Color.Transparent
        Me.tbProxyPort.LargeChange = 10
        Me.tbProxyPort.Location = New System.Drawing.Point(69, 3)
        Me.tbProxyPort.Maximum = 2500
        Me.tbProxyPort.Minimum = 200
        Me.tbProxyPort.Name = "tbProxyPort"
        Me.tbProxyPort.Size = New System.Drawing.Size(534, 23)
        Me.tbProxyPort.Style = MetroFramework.MetroColorStyle.Red
        Me.tbProxyPort.TabIndex = 0
        Me.tbProxyPort.Value = 808
        '
        'tbLiveRewind
        '
        Me.tbLiveRewind.BackColor = System.Drawing.Color.Transparent
        Me.tbLiveRewind.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbLiveRewind.LargeChange = 3
        Me.tbLiveRewind.Location = New System.Drawing.Point(3, 1)
        Me.tbLiveRewind.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbLiveRewind.Maximum = 60
        Me.tbLiveRewind.Minimum = 1
        Me.tbLiveRewind.Name = "tbLiveRewind"
        Me.tbLiveRewind.Size = New System.Drawing.Size(344, 29)
        Me.tbLiveRewind.SmallChange = 2
        Me.tbLiveRewind.Style = MetroFramework.MetroColorStyle.Red
        Me.tbLiveRewind.TabIndex = 0
        Me.tbLiveRewind.Value = 1
        '
        'cbLiveReplay
        '
        Me.cbLiveReplay.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbLiveReplay.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbLiveReplay.FormattingEnabled = True
        Me.cbLiveReplay.ItemHeight = 19
        Me.cbLiveReplay.Location = New System.Drawing.Point(177, 213)
        Me.cbLiveReplay.Name = "cbLiveReplay"
        Me.cbLiveReplay.Size = New System.Drawing.Size(600, 25)
        Me.cbLiveReplay.Style = MetroFramework.MetroColorStyle.Red
        Me.cbLiveReplay.TabIndex = 522
        Me.cbLiveReplay.UseSelectable = True
        '
        'MLBGamesMetro
        '
        Me.AccessibleDescription = "Watch NHL games for free in HD"
        Me.AccessibleName = "MLBGames"
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackMaxSize = 150
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(990, 655)
        Me.Controls.Add(Me.pnlLogo)
        Me.Controls.Add(Me.spnStreaming)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.tabMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.MinimumSize = New System.Drawing.Size(990, 500)
        Me.Name = "MLBGamesMetro"
        Me.Padding = New System.Windows.Forms.Padding(3, 70, 3, 3)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "MLBGames"
        Me.tabMenu.ResumeLayout(False)
        Me.tabGames.ResumeLayout(False)
        Me.tabGames.PerformLayout()
        Me.pnlGameBar.ResumeLayout(False)
        Me.tabStandings.ResumeLayout(False)
        Me.tlpStandings.ResumeLayout(False)
        Me.tlpStandings.PerformLayout()
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.tlpSettings.ResumeLayout(False)
        Me.tlpSettings.PerformLayout()
        Me.tlpOBSSettings.ResumeLayout(False)
        Me.tlpOBSSettings.PerformLayout()
        Me.flpGameSceneHotkey.ResumeLayout(False)
        Me.flpGameSceneHotkey.PerformLayout()
        Me.flpAdSceneHotkey.ResumeLayout(False)
        Me.flpAdSceneHotkey.PerformLayout()
        Me.flpObsDescSettings.ResumeLayout(False)
        Me.flpObsDescSettings.PerformLayout()
        Me.flpSpotifyDescSettings.ResumeLayout(False)
        Me.flpSpotifyDescSettings.PerformLayout()
        Me.flpStreamerArgs.ResumeLayout(False)
        Me.flpStreamerArgs.PerformLayout()
        Me.flpPlayerArgs.ResumeLayout(False)
        Me.flpPlayerArgs.PerformLayout()
        Me.flpOutputSettings.ResumeLayout(False)
        Me.flpOutputSettings.PerformLayout()
        Me.flpStreamerPath.ResumeLayout(False)
        Me.flpStreamerPath.PerformLayout()
        Me.flpMpvPath.ResumeLayout(False)
        Me.flpMpvPath.PerformLayout()
        Me.flpMpcPath.ResumeLayout(False)
        Me.flpMpcPath.PerformLayout()
        Me.flpVlcPath.ResumeLayout(False)
        Me.flpVlcPath.PerformLayout()
        Me.flpLanguage.ResumeLayout(False)
        Me.flpHostsFile.ResumeLayout(False)
        Me.tlpGamePanelSettings.ResumeLayout(False)
        Me.tlpGamePanelSettings.PerformLayout()
        Me.flpSelectedPlayer.ResumeLayout(False)
        Me.tlpCdnSettings.ResumeLayout(False)
        Me.tlpCdnSettings.PerformLayout()
        Me.flpSpotifyParameters.ResumeLayout(False)
        Me.flpSpotifyParameters.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.flpAdDetection.ResumeLayout(False)
        Me.flpAdDetection.PerformLayout()
        Me.tlpReplay.ResumeLayout(False)
        Me.tlpReplay.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.tabConsole.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.tlpStatus.ResumeLayout(False)
        Me.tlpStatus.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtConsole As RichTextBox
    Friend WithEvents tabMenu As MetroTabControl
    Friend WithEvents tabGames As MetroTabPage
    Friend WithEvents tabSettings As MetroTabPage
    Friend WithEvents tabConsole As MetroTabPage
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents btnClearConsole As MetroButton
    Friend WithEvents btnDate As Button
    Friend WithEvents btnTomorrow As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents tmr As Timer
    Friend WithEvents flpGames As FlowLayoutPanel
    Friend WithEvents flpCalendarPanel As FlowLayoutPanel
    Friend WithEvents lblNoGames As Label
    Friend WithEvents tt As MetroToolTip
    Friend WithEvents btnYesterday As Button
    Friend WithEvents lblDate As MetroLabel
    Friend WithEvents pnlBottom As MetroPanel
    Friend WithEvents lnkReddit As MetroLink
    Friend WithEvents lblStatus As MetroLabel
    Friend WithEvents lblVersion As MetroLabel
    Friend WithEvents btnCopyConsole As MetroButton
    Friend WithEvents spnStreaming As MetroProgressSpinner
    Friend WithEvents spnLoading As MetroProgressSpinner
    Friend WithEvents tlpSettings As TableLayoutPanel
    Friend WithEvents lblStreamerArgs As MetroLabel
    Friend WithEvents lblPlayerArgs As MetroLabel
    Friend WithEvents lblOutput As MetroLabel
    Friend WithEvents flpStreamerArgs As FlowLayoutPanel
    Friend WithEvents txtStreamerArgs As TextBox
    Friend WithEvents tgStreamer As MetroToggle
    Friend WithEvents flpPlayerArgs As FlowLayoutPanel
    Friend WithEvents txtPlayerArgs As TextBox
    Friend WithEvents tgPlayer As MetroToggle
    Friend WithEvents flpOutputSettings As FlowLayoutPanel
    Friend WithEvents txtOutputArgs As TextBox
    Friend WithEvents btnOutput As MetroButton
    Friend WithEvents tgOutput As MetroToggle
    Friend WithEvents flpStreamerPath As FlowLayoutPanel
    Friend WithEvents txtStreamerPath As TextBox
    Friend WithEvents btnStreamerPath As MetroButton
    Friend WithEvents flpMpvPath As FlowLayoutPanel
    Friend WithEvents txtMpvPath As TextBox
    Friend WithEvents btnMpvPath As MetroButton
    Friend WithEvents flpMpcPath As FlowLayoutPanel
    Friend WithEvents txtMPCPath As TextBox
    Friend WithEvents btnMPCPath As MetroButton
    Friend WithEvents lnkGetMpc As MetroLink
    Friend WithEvents flpVlcPath As FlowLayoutPanel
    Friend WithEvents txtVLCPath As TextBox
    Friend WithEvents btnVLCPath As MetroButton
    Friend WithEvents lnkGetVlc As MetroLink
    Friend WithEvents lblLanguage As MetroLabel
    Friend WithEvents flpLanguage As FlowLayoutPanel
    Friend WithEvents lblSlPath As MetroLabel
    Friend WithEvents lblMpvPath As MetroLabel
    Friend WithEvents lblMpcPath As MetroLabel
    Friend WithEvents lblVlcPath As MetroLabel
    Friend WithEvents lblHostname As MetroLabel
    Friend WithEvents lblQuality As MetroLabel
    Friend WithEvents lblCdn As MetroLabel
    Friend WithEvents lblPlayer As MetroLabel
    Friend WithEvents lblGamePanel As MetroLabel
    Friend WithEvents lblProxyPort As MetroLabel
    Friend WithEvents flpHostsFile As FlowLayoutPanel
    Friend WithEvents fbd As FolderBrowserDialog
    Friend WithEvents tlpGamePanelSettings As TableLayoutPanel
    Friend WithEvents lblShowFinalScores As MetroLabel
    Friend WithEvents lblShowLiveScores As MetroLabel
    Friend WithEvents lblShowSeriesRecord As MetroLabel
    Friend WithEvents tgShowFinalScores As MetroToggle
    Friend WithEvents tgShowLiveScores As MetroToggle
    Friend WithEvents tgShowSeriesRecord As MetroToggle
    Friend WithEvents flpSelectedPlayer As FlowLayoutPanel
    Friend WithEvents rbVLC As MetroRadioButton
    Friend WithEvents rbMPC As MetroRadioButton
    Friend WithEvents rbMPV As MetroRadioButton
    Friend WithEvents tlpCdnSettings As TableLayoutPanel
    Friend WithEvents tgAlternateCdn As MetroToggle
    Friend WithEvents lblUseAlternateCdn As MetroLabel
    Friend WithEvents lblMedia As MetroLabel
    Friend WithEvents lblOBS As MetroLabel
    Friend WithEvents flpSpotifyDescSettings As FlowLayoutPanel
    Friend WithEvents tgMedia As MetroToggle
    Friend WithEvents lblMediaDesc As MetroLabel
    Friend WithEvents flpSpotifyParameters As FlowLayoutPanel
    Friend WithEvents chkSpotifyForceToStart As MetroCheckBox
    Friend WithEvents chkSpotifyPlayNextSong As MetroCheckBox
    Friend WithEvents flpObsDescSettings As FlowLayoutPanel
    Friend WithEvents tgOBS As MetroToggle
    Friend WithEvents lblOBSDesc As MetroLabel
    Friend WithEvents tlpOBSSettings As TableLayoutPanel
    Friend WithEvents lblObsAdEndingHotkey As MetroLabel
    Friend WithEvents lblObsAdStartingHotkey As MetroLabel
    Friend WithEvents flpGameSceneHotkey As FlowLayoutPanel
    Friend WithEvents txtGameKey As MetroTextBox
    Friend WithEvents lblPlus1 As MetroLabel
    Friend WithEvents chkGameCtrl As MetroCheckBox
    Friend WithEvents lblPlus2 As MetroLabel
    Friend WithEvents chkGameAlt As MetroCheckBox
    Friend WithEvents lblPlus3 As MetroLabel
    Friend WithEvents chkGameShift As MetroCheckBox
    Friend WithEvents flpAdSceneHotkey As FlowLayoutPanel
    Friend WithEvents txtAdKey As MetroTextBox
    Friend WithEvents lblPlus4 As MetroLabel
    Friend WithEvents chkAdCtrl As MetroCheckBox
    Friend WithEvents lblPlus5 As MetroLabel
    Friend WithEvents chkAdAlt As MetroCheckBox
    Friend WithEvents lblPlus6 As MetroLabel
    Friend WithEvents chkAdShift As MetroCheckBox
    Friend WithEvents lblModules As MetroLabel
    Friend WithEvents tgModules As MetroToggle
    Friend WithEvents chkSpotifyHotkeys As MetroCheckBox
    Friend WithEvents pnlGameBar As MetroPanel
    Friend WithEvents tgShowTeamCityAbr As MetroToggle
    Friend WithEvents lblShowTeamCityAbr As MetroLabel
    Friend WithEvents flpAdDetection As FlowLayoutPanel
    Friend WithEvents lblModulesDesc As MetroLabel
    Friend WithEvents tgShowTodayLiveGamesFirst As MetroToggle
    Friend WithEvents lblShowTodayLiveGamesFirst As MetroLabel
    Friend WithEvents bw As BackgroundWorker
    Friend WithEvents tlpReplay As TableLayoutPanel
    Friend WithEvents lblLiveRewindDetails As MetroLabel
    Friend WithEvents lblLiveRewind As MetroLabel
    Friend WithEvents lblLiveReplay As MetroLabel
    Friend WithEvents lblVLCLogo As Label
    Friend WithEvents lvlMPCHCLogo As Label
    Friend WithEvents lblMPVLogo As Label
    Friend WithEvents tgShowLiveTime As MetroToggle
    Friend WithEvents lblShowLiveTime As MetroLabel
    Friend WithEvents tgDarkMode As MetroToggle
    Friend WithEvents lblDarkMode As MetroLabel
    Friend WithEvents btnHelp As MetroLink
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents lblProxyPortNumber As MetroLabel
    Friend WithEvents cbServers As MLBGames.Controls.MetroComboBoxNoMW
    Friend WithEvents cbLanguage As MLBGames.Controls.MetroComboBoxNoMW
    Friend WithEvents cbStreamQuality As MLBGames.Controls.MetroComboBoxNoMW
    Friend WithEvents tbLiveRewind As MLBGames.Controls.MetroTrackBarNoMW
    Friend WithEvents cbLiveReplay As MLBGames.Controls.MetroComboBoxNoMW
    Friend WithEvents tbProxyPort As MLBGames.Controls.MetroTrackBarNoMW
    Friend WithEvents tlpStatus As TableLayoutPanel
    Friend WithEvents lnkRelease As MetroLink
    Friend WithEvents lblTip As MetroLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblMediaControlDelay As MetroLabel
    Friend WithEvents lblMediaControlDelayMs As MetroLabel
    Friend WithEvents txtMediaControlDelay As MetroTextBox
    Friend WithEvents lblShowStanding As MetroLabel
    Friend WithEvents tgShowStanding As MetroToggle
    Friend WithEvents tbStanding As MetroTabControl
    Friend WithEvents cbSeasons As MLBGames.Controls.MetroComboBoxNoMW
    Friend WithEvents lblSeason As MetroLabel
    Friend WithEvents tlpStandings As TableLayoutPanel
    Friend WithEvents tabStandings As MetroTabPage
    Friend WithEvents lblReset As MetroLabel
    Friend WithEvents tgReset As MetroToggle
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblResetDesc As MetroLabel
End Class
