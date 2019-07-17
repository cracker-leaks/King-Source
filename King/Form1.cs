//Requirements

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using FlatUI;
using WeAreDevs_API;

namespace King
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000002 RID: 2
		[DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool LaunchExploit();

		// Token: 0x06000003 RID: 3
		[DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool SendLuaCScript(string script);

		// Token: 0x06000004 RID: 4
		[DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool SendLimitedLuaScript(string script);

		// Token: 0x06000005 RID: 5
		[DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool SendCommand(string script);

		// Token: 0x06000006 RID: 6
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000007 RID: 7
		private void flatListBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8
		private void flatListBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9
		private void UPDATES_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10
		private void flatButton4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("TO ACTIVATE ANTI-BAN GO TO THE ANTI-BAN FOLDER AND RUN EXE");
		}

		//TopMost
		// Token: 0x0600000B RID: 11
		private void flatCheckBox1_CheckedChanged(object sender)
		{
			if (!this.flatCheckBox1.Checked)
			{
				if (!this.flatCheckBox1.Checked)
				{
					base.TopMost = false;
					return;
				}
			}
			else
			{
				base.TopMost = true;
			}
		}

		//KillRoblox
		// Token: 0x0600000C RID: 12
		private void flatButton5_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		// Token: 0x0600000D RID: 13
		private void flatButton2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14
		private void flatButton3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15
		private void flatButton1_Click(object sender, EventArgs e)
		{
			this.API.LaunchExploit();
			this.flatLabel4.Text = "STATUS: INJECTED";
		}

		// Token: 0x06000010 RID: 16
		private void flatLabel3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17
		[DllImport("shlwapi.dll")]
		public static extern int ColorHLSToRGB(int int_1, int int_2, int int_3);

		// Token: 0x06000012 RID: 18
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.int_0++;
			if (this.int_0 > 239)
			{
				this.int_0 = 0;
			}
			this.formSkin1.FlatColor = ColorTranslator.FromWin32(Form1.ColorHLSToRGB(this.int_0, 120, 240));
			this.formSkin1.Refresh();
		}

		// Token: 0x06000013 RID: 19
		private void flatCheckBox2_CheckedChanged(object sender)
		{
			this.timer1.Enabled = this.flatCheckBox2.Checked;
		}

		// Token: 0x06000014 RID: 20
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21
		private void flatButton10_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Text = "";
		}

		// Token: 0x06000016 RID: 22
		private void flatButton11_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox1.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x06000017 RID: 23
		private void flatButton9_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox1.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x06000018 RID: 24
		private void flatButton6_Click(object sender, EventArgs e)
		{
			this.API.CreateForceField("me");
		}

		// Token: 0x06000019 RID: 25
		private void flatButton7_Click(object sender, EventArgs e)
		{
			this.API.AddFire("me");
		}

		// Token: 0x0600001A RID: 26
		private void flatButton14_Click(object sender, EventArgs e)
		{
			this.API.AddSmoke("me");
		}

		// Token: 0x0600001B RID: 27
		private void flatButton13_Click(object sender, EventArgs e)
		{
			this.API.AddSparkles("me");
		}

		// Token: 0x0600001C RID: 28
		private void flatButton12_Click(object sender, EventArgs e)
		{
			this.API.DoBTools("me");
		}

		// Token: 0x0600001D RID: 29
		private void flatButton8_Click(object sender, EventArgs e)
		{
			this.API.SetJumpPower(100);
		}

		// Token: 0x0600001E RID: 30
		private void flatButton18_Click(object sender, EventArgs e)
		{
			string text = this.flatTextBox7.Text;
			this.API.SetWalkSpeed(text, 100);
		}

		// Token: 0x0600001F RID: 31
		private void flatButton17_Click(object sender, EventArgs e)
		{
			string text = this.flatTextBox2.Text;
			this.API.TeleportMyCharacterTo(text);
		}

		// Token: 0x06000020 RID: 32
		private void flatTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33
		private void flatButton15_Click(object sender, EventArgs e)
		{
			this.API.ToggleClickTeleport();
		}

		// Token: 0x06000022 RID: 34
		private void flatButton16_Click(object sender, EventArgs e)
		{
			this.API.DoKill("me");
		}

		// Token: 0x06000023 RID: 35
		private void formSkin1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36
		private void flatButton3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37
		private void tabPage3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38
		private void flatButton19_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39
		private void flatButton26_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40
		private void flatButton25_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41
		private void flatButton24_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42
		private void flatButton20_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.roblox.com/games/606849621/Jailbreak?privateServerLinkCode=iEAQS9K1JmE7ioc_mXhQgq54_Wfnzjk-");
		}

		// Token: 0x0600002B RID: 43
		private void flatButton19_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.roblox.com/games/292439477/New-Steel-II-Phantom-Forces?privateServerLinkCode=OnIil4GSjlsb73sekbTr63xMQFBVQ8pw");
		}

		// Token: 0x0600002C RID: 44
		private void flatButton3_Click_2(object sender, EventArgs e)
		{
			Process.Start("https://www.roblox.com/games/142823291/Murder-Mystery-2?privateServerLinkCode=1PaSoh7zBz-Nw6PgwAp4JuonvULvdO37");
		}

		// Token: 0x0600002D RID: 45
		private void flatButton21_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.roblox.com/games/1320186298/Island-Royale-Beta?privateServerLinkCode=owSKpCjpM6HAa-RR9lW1ibjIe58CJk8g");
		}

		// Token: 0x0600002E RID: 46
		private void flatButton23_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-222, 17, 1575)\nscript:Destroy()");
		}

		// Token: 0x0600002F RID: 47
		private void flatButton22_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(1637, 50, -1768)\nscript:Destroy()");
		}

		// Token: 0x06000030 RID: 48
		private void flatButton28_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-1130, 17, -1593)\nscript:Destroy()");
		}

		// Token: 0x06000031 RID: 49
		private void flatButton27_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack, true)\nplr = game:GetService(\"Players\").LocalPlayer\nchar = plr.Character\nhum = char.Humanoid\ntool5 = Instance.new(\"HopperBin\", plr.Backpack)\ntool5.Name = \"click unlock\"\nmouse = plr:GetMouse()\n\ntool5.Selected:connect(function()\nmouse.Button1Down:connect(function()\nmouse.Target.Locked = false\nend)\nend)\nc = Instance.new(\"HopperBin\", game:GetService(\"Players\").LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Hammer");
		}

		// Token: 0x06000032 RID: 50
		private void flatButton26_Click_1(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(736, 38, 1130)\nscript:Destroy()");
		}

		// Token: 0x06000033 RID: 51
		private void flatButton25_Click_1(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(13, 17, 789)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000034 RID: 52
		private void flatButton24_Click_1(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(136, 19, 1318)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000035 RID: 53
		private void flatButton29_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local plr = game:GetService(\"Players\").LocalPlayer\nGiver = {}\n\tlocal g = Giver\n\tlocal p = Instance.new(\"Part\", workspace)\n\tp.Anchored = true\n\tp.CanCollide = false\n\tp.CFrame = plr.Character:WaitForChild\"HumanoidRootPart\".CFrame\n\tsetmetatable(Giver, {__metatable = p})\n\tfor i,v in pairs(workspace.Givers:GetChildren()) do\n\t\tlocal cd = v:FindFirstChildOfClass\"ClickDetector\"\n\t\tif cd then\n\t\t\tlocal newt = {}\n\t\t\tnewt.ClickDetector = cd\n\t\t\tnewt.OriginalParent = v\n\t\t\tcd.Parent = p\n\t\t\tnewt.Event = cd.MouseClick:connect(function()\n\t\t\t\tcd.Parent = v\n\t\t\tend)\n\t\t\ttable.insert(Giver, newt)\n\t\tend\n\tend\n\tspawn(function()\n\t\twait(10)\n\t\tif Giver == g then\n\t\t\tGiver = nil\n\t\t\tfor i,v in pairs(g) do\n\t\t\t\tv.ClickDetector.Parent = v.OriginalParent\n\t\t\t\tv.Event:Disconnect()\n\t\t\tend\n\t\t\tgetmetatable(g):Destroy()\n\t\tend\n\tend)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000036 RID: 54
		private void flatButton37_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(267, 19, -1796)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000037 RID: 55
		private void flatButton36_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-1548, 17, 701)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000038 RID: 56
		private void flatButton35_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 50 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.1)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(19, 17, 840)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(31, 1, 814)\nwait(2)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(18, 5, 804)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000039 RID: 57
		private void flatButton34_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x0600003A RID: 58
		private void flatButton33_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService(\"UserInputService\").JumpRequest:connect(function()\ngame:GetService\"Players\".LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState(\"Jumping\")\nend)");
		}

		// Token: 0x0600003B RID: 59
		private void flatButton32_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i,v in pairs(game:GetService(\"Teams\").Criminal:GetPlayers()) do\nwait()\nlocal as = 0\nwhile as < 30 do\ngame:GetService(\"Players\").LocalPlayer.Character.HumanoidRootPart.CFrame = v.Character.HumanoidRootPart.CFrame * CFrame.new(0, 0, 1)\nwait(0.1)\nas = as + 1\nend\nend\nscript:Destroy()");
		}

		// Token: 0x0600003C RID: 60
		private void flatButton31_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(138.581238, 18.1094494, -1769.56287)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x0600003D RID: 61
		private void flatButton30_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("plr = game:GetService('Players').LocalPlayer.PlayerGui plr.MainGui.Nitro.Name = 'Nitr' plr.ProductGui.Nitro.Parent = game.Lighting b = Instance.new('Model', plr.ProductGui) b.Name = 'Nitro'");
		}

		// Token: 0x0600003E RID: 62
		private void flatButton44_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack, true)\nplr = game:GetService('Players').LocalPlayer\nchar = plr.Character\nhum = char.Humanoid\ntool54 = Instance.new(\"HopperBin\", plr.Backpack)\ntool54.Name = \"Click Teleport\"\nmouse = plr:GetMouse()\n\ntool54.Selected:connect(function()\nmouse.Button1Down:connect(function()\nif tool54.Active then\n\nchar.HumanoidRootPart.CFrame = mouse.Target.CFrame\n\nend\nend)\nend)");
		}

		// Token: 0x0600003F RID: 63
		private void flatButton43_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i,v in pairs(game:GetService(\"Teams\").Criminal:GetPlayers()) do\nwait()\nlocal as = 0\nwhile as < 30 do\ngame:GetService(\"Players\").LocalPlayer.Character.HumanoidRootPart.CFrame = v.Character.HumanoidRootPart.CFrame * CFrame.new(0, 0, 1)\nwait(0.1)\nas = as + 1\nend\nend\nscript:Destroy()");
		}

		// Token: 0x06000040 RID: 64
		private void flatButton38_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press Q when you get arrested to un-arrest yourself!");
			this.API.SendLuaScript("while wait(1) do game.Workspace.TouchTrigger.Donut.Position = game:GetService('Players').LocalPlayer.Character.Head.Position end");
			this.API.SendLuaScript("local wrk = game:GetService('Workspace') local plr = game:GetService('Players').LocalPlayer local mouse = plr:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'q' or key:upper() == 'Q' then if plr.Character.Handcuffs ~= nil then b = Instance.new('Part') b.Name = ('Gad') b.Parent = wrk b.CFrame = CFrame.new(plr.Character.UpperTorso.Position) b.Anchored = true b.CanCollide = false b.Transparency = 0.05 wait(10) plr.Character.HumanoidRootPart.CFrame = CFrame.new(wrk.Gad.Position) b:Destroy() end end end)");
		}

		// Token: 0x06000041 RID: 65
		private void flatButton42_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-970, 20, -1450)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000042 RID: 66
		private void flatButton41_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox3.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x06000043 RID: 67
		private void flatButton40_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 1 local l = game:GetService('Players').LocalPlayer.Character['1']:Clone() l.Parent = game:GetService('Players').LocalPlayer.Character l.Name = 'Humanoid' wait(0.1) game:GetService('Players').LocalPlayer.Character['1']:Destroy() game:GetService('Workspace').CurrentCamera.CameraSubject = game:GetService('Players').LocalPlayer.Character game:GetService('Players').LocalPlayer.Character.Animate.Disabled = true wait(0.1) game:GetService('Players').LocalPlayer.Character.Animate.Disabled = false game:GetService('Players').LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
		}

		// Token: 0x06000044 RID: 68
		private void flatButton45_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("Workspace.Bush:Destroy()\nWorkspace.Buildings:ClearAllChildren()\nWorkspace.Apartments:ClearAllChildren()\nWorkspace.Trees:ClearAllChildren()");
			this.API.SendLuaScript("game.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\n\ngame.Workspace.Jewelrys:GetChildren()[1].Model.BarbedWire:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.BarbedWire:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.BarbedWire:Destroy()\n\ngame.Workspace.Jewelrys:GetChildren()[1].FakeDoor:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].FakeDoor:Destroy()\n\ngame.Workspace.Jewelrys:GetChildren()[1].Wall:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Wall:Destroy()\nscript:Destroy()");
			this.API.SendLuaScript("for i,v in pairs(Workspace.Doors:GetChildren()) do\nv.Model:ClearAllChildren()\nend");
		}

		// Token: 0x06000045 RID: 69
		private void flatButton49_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-1176.4231, 59.7911148, -1572.6908)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000046 RID: 70
		private void flatButton48_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press 'G' to use rainbow path.");
			this.API.SendLuaScript("local player = game:GetService('Players').LocalPlayer local mouse = player:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'g' or key:upper() == 'G' then for i = 1,6 do wait(0.25) x = Instance.new('Part',game:GetService('Workspace')) x.Size = Vector3.new(10,0.2,10) x.TopSurface = 'Smooth' x.Anchored = true x.BrickColor = BrickColor.random()  x.CFrame = CFrame.new(player.Character.UpperTorso.Position) + Vector3.new(0,-3,0) game.Debris:AddItem(x, 3) end end end)");
		}

		// Token: 0x06000047 RID: 71
		private void flatButton47_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1579.4823, 49.787693, -1759.61438) end");
		}

		// Token: 0x06000048 RID: 72
		private void flatButton46_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("b = workspace:FindFirstChild(\"Banks\"):GetChildren()[1].Extra.Sign.Decal\nj = workspace.Jewelrys:FindFirstChild('Extra', true).Sign.Decal\nif b.Transparency == 0 then\nwarn(\"Bank is Closed\")\nif j.Transparency == 0 then\nwarn(\"Jewelry is Closed\")\nelse\nprint(\"Jewelry Ready\")\nend\nelse\nprint(\"Bank ready\")\nend\nscript:Destroy()");
			MessageBox.Show("Press F9 To See If Stores are open.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000049 RID: 73
		private void flatButton52_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(144.794067, 17.6189003, 768.572693) end");
		}

		// Token: 0x0600004A RID: 74
		private void flatButton51_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-111.571999, 17.6169529, 541.515747) end");
		}

		// Token: 0x0600004B RID: 75
		private void flatButton50_Click(object sender, EventArgs e)
		{
			this.API.SendLuaCScript("getglobal game\r\ngetfield -1 Workspace\r\ngetfield -1 Doors\r\ngetfield -1 Destroy\r\npushvalue -2\r\npcall 1 0 0\r\nemptystack");
		}

		// Token: 0x0600004C RID: 76
		private void flatButton55_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("while true do for i, v in pairs(game.Teams.Police:GetPlayers()) do p = game:GetService('Players') e = Instance.new('BoxHandleAdornment') e.Color3 = Color3.new(0,0,1) e.Size = Vector3.new(2,1.6,1) e.ZIndex = 1 e.AlwaysOnTop = true e.Parent = game:GetService('Workspace') e.Adornee = v.Character.UpperTorso end wait(5) e:Destroy() end");
		}

		// Token: 0x0600004D RID: 77
		private void flatButton54_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("while true do for i,v in pairs(game.Teams.Criminal:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(255,0,0) e.Size=Vector3.new(2,1.6,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.UpperTorso end wait(5) e:Destroy() end");
		}

		// Token: 0x0600004E RID: 78
		private void flatButton53_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("while true do for i,v in pairs(game.Teams.Prisoner:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(255,77,0) e.Size=Vector3.new(2,1.6,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.UpperTorso end wait(5) e:Destroy() end");
		}

		// Token: 0x0600004F RID: 79
		private void flatButton57_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Parent = game.Lighting\r\n                                 game.Lighting.HumanoidRootPart.Parent = game:GetService('Players').LocalPlayer.Character");
		}

		// Token: 0x06000050 RID: 80
		private void flatButton56_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press R to fly while in a car!");
			this.API.SendLuaScript("local plr = game:GetService'Players'.LocalPlayer\r\nlocal m = plr:GetMouse()\r\nm.KeyDown:connect(function(k)\r\nif k:byte() == 114 then\r\nplrh = game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid'\r\nplrh:ChangeState('Jumping')\r\nwait()\r\nplrh:ChangeState('Seated')\r\nend\r\nend)");
		}

		// Token: 0x06000051 RID: 81
		private void flatButton63_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-170, 18.6, 1057.1) end");
		}

		// Token: 0x06000052 RID: 82
		private void flatButton62_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1541.10388, 17.746624, 729) end");
		}

		// Token: 0x06000053 RID: 83
		private void flatButton61_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1355.2417, 18, -1531.86047) end");
		}

		// Token: 0x06000054 RID: 84
		private void flatButton60_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-453.2, 13.6, 418.2) end");
		}

		// Token: 0x06000055 RID: 85
		private void flatButton59_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1453.4, 25.6, 201.4) end");
		}

		// Token: 0x06000056 RID: 86
		private void flatButton58_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1473.9, -0.30, -1877.6) end");
		}

		// Token: 0x06000057 RID: 87
		private void flatButton65_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(245.938766, 17.6064777, 1372.15076) end");
		}

		// Token: 0x06000058 RID: 88
		private void flatButton64_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1312.1, 18.1, 376) end");
		}

		// Token: 0x06000059 RID: 89
		private void flatButton70_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90
		private void flatButton69_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1957.1, 68.8, -604) end");
		}

		// Token: 0x0600005B RID: 91
		private void flatButton66_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(578.7, 17.8, -460.1) end");
		}

		// Token: 0x0600005C RID: 92
		private void flatButton68_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-97.5, 18.3, -1724) end");
		}

		// Token: 0x0600005D RID: 93
		private void flatButton67_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-653.4, 20.4, -246.4) end");
		}

		// Token: 0x0600005E RID: 94
		private void flatButton73_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(761.3, 18.5, -1227.2) end");
		}

		// Token: 0x0600005F RID: 95
		private void flatButton72_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x06000060 RID: 96
		private void flatButton71_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1499.6, 50.2, 1803.1) end");
		}

		// Token: 0x06000061 RID: 97
		private void flatButton77_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1167.1, 18.7, -1374.5) end");
		}

		// Token: 0x06000062 RID: 98
		private void flatButton76_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(391.1, 43.1, -1722.9) end");
		}

		// Token: 0x06000063 RID: 99
		private void flatButton75_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1188.7, 18.4, -1536.1) end");
		}

		// Token: 0x06000064 RID: 100
		private void flatButton74_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1112.11475, 101.16069, 1290.57654) end");
		}

		// Token: 0x06000065 RID: 101
		private void flatButton81_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000066 RID: 102
		private void flatButton80_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x06000067 RID: 103
		private void flatButton79_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(598.6, 38.3, 1646.6) end");
		}

		// Token: 0x06000068 RID: 104
		private void flatButton82_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1078.45, 153.904, 1176.52) + Vector3.new(1,0,0)");
		}

		// Token: 0x06000069 RID: 105
		private void flatButton83_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1132.674, 100.412, 1230.48) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600006A RID: 106
		private void flatButton85_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1063.02, 117.562, 1218.757) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600006B RID: 107
		private void flatButton86_Click(object sender, EventArgs e)
		{
			this.API.SendLuaCScript("getglobal game\ngetfield -1 GetService\npushvalue -2\npushstring Lighting\npcall 2 1 0\npushnumber 100\nsetfield -2 FogEnd\nemptystack");
		}

		// Token: 0x0600006C RID: 108
		private void flatButton89_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game.Workspace.Buildings:Destroy()");
		}

		// Token: 0x0600006D RID: 109
		private void flatButton88_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i,v in pairs(game:GetService('Workspace').Buildings:GetChildren()) do v.CanCollide = false end");
		}

		// Token: 0x0600006E RID: 110
		private void flatButton87_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x0600006F RID: 111
		private void flatButton90_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Binoculars' then v.CFrame = CFrame.new(hit) end end end end end");
		}

		// Token: 0x06000070 RID: 112
		private void flatButton94_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').Name = 'Players' game.Players.LocalPlayer.leaderstats.Money.Value = 99999999");
		}

		// Token: 0x06000071 RID: 113
		private void flatButton93_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("vlocal hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Flashlight' then v.CFrame = CFrame.new(hit) end end end end end");
		}

		// Token: 0x06000072 RID: 114
		private void flatButton92_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("while wait(2) do game:GetService('Workspace').TouchTrigger.Donut.Position = game:GetService('Players').LocalPlayer.Character.Head.Position end");
		}

		// Token: 0x06000073 RID: 115
		private void flatButton78_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Note: You must have full duffle bag for this to work! We will improve it in the next update!");
			this.API.SendLuaScript("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$3,000') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('3,00O') wait(60) end end else warn('The Bank is Closed!') end end");
		}

		// Token: 0x06000074 RID: 116
		private void flatCheckBox6_CheckedChanged(object sender)
		{
			if (!this.flatCheckBox6.Checked)
			{
				this.API.SendLuaScript("game:GetService('Players').LocalPlayer:FindFirstChildOfClass'PlayerGui'.MainGui.Ammo.MagSize.RobloxLocked = false\nscript:Destroy()");
			}
			else
			{
				this.API.SendLuaScript("game:GetService('Players').LocalPlayer:FindFirstChildOfClass'PlayerGui'.MainGui.Ammo.MagSize.RobloxLocked = true\nscript:Destroy()");
			}
			this.Refresh();
		}

		// Token: 0x06000075 RID: 117
		private void flatCheckBox7_CheckedChanged(object sender)
		{
			if (this.flatCheckBox7.Checked)
			{
				this.API.SendLuaScript("_G.WS = 200;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('WalkSpeed'):Connect(function()\r\n             Humanoid.WalkSpeed = _G.WS;\r\n            end)\r\nHumanoid.WalkSpeed = _G.WS;");
				return;
			}
			if (!this.flatCheckBox7.Checked)
			{
				this.API.SendLuaScript("_G.WS = 20;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('WalkSpeed'):Connect(function()\r\n             Humanoid.WalkSpeed = _G.WS;\r\n            end)\r\nHumanoid.WalkSpeed = _G.WS;");
			}
		}

		// Token: 0x06000076 RID: 118
		private void flatCheckBox4_CheckedChanged(object sender)
		{
			if (this.flatCheckBox4.Checked)
			{
				this.API.SendLuaScript("plr = game:GetService('Players').LocalPlayer.PlayerGui plr.MainGui.Nitro.Name = 'Nitr' plr.ProductGui.Nitro.Parent = game.Lighting b = Instance.new('Model', plr.ProductGui) b.Name = 'Nitro'");
				return;
			}
			if (!this.flatCheckBox4.Checked)
			{
				this.API.SendLuaScript("plr = game:GetService('Players')  plr.LocalPlayer.PlayerGui.ProductGui.Nitro:Destroy() game.Lighting.Nitro.Parent = plr.LocalPlayer.PlayerGui.ProductGui plr.LocalPlayer.PlayerGui.MainGui.Nitro.Name = 'Nitro'");
			}
		}

		// Token: 0x06000077 RID: 119
		private void flatCheckBox3_CheckedChanged(object sender)
		{
			if (this.flatCheckBox3.Checked)
			{
				if (!this.flatCheckBox3.Checked)
				{
					this.API.SendLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
					return;
				}
				this.API.SendLuaScript("game:GetService('Workspace').Gravity = 0\nscript:Destroy()");
				return;
			}
			else
			{
				if (!this.flatCheckBox3.Checked)
				{
					this.API.SendLuaScript("game:GetService('Workspace').Gravity = 196.2\nscript:Destroy()");
					return;
				}
				this.API.SendLuaScript("game:GetService('Workspace').Gravity = 0\nscript:Destroy()");
				return;
			}
		}

		// Token: 0x06000078 RID: 120
		private void flatCheckBox5_CheckedChanged(object sender)
		{
			if (this.flatCheckBox5.Checked)
			{
				this.API.SendLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
				return;
			}
			this.API.SendLuaScript("game:GetService('Workspace').Gravity = 196.2\nscript:Destroy()");
		}

		// Token: 0x06000079 RID: 121
		private void flatButton96_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Note: You must have full duffel bag for this to work!");
			this.API.SendLuaScript("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$3,000') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('3,00O') wait(60) end end else warn('The Bank is Closed!') end end");
		}

		// Token: 0x0600007A RID: 122
		private void flatButton97_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(2) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(14) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(16, 5, 815) wait(30) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1.1110189, 17.9213142, 782.103455)");
		}

		// Token: 0x0600007B RID: 123
		private void flatButton98_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(2) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(14) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(16, 5, 815) wait(48) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1.1110189, 17.9213142, 782.103455)");
		}

		// Token: 0x0600007C RID: 124
		private void flatButton99_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press F9 To See If Stores are open.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.API.SendLuaScript("function GetFrom(model) return game:GetService'Workspace'[tostring(model)]:GetChildren()[1].Extra:FindFirstChild'Sign'.Decal; end local bank = GetFrom'Banks' local jewelry = GetFrom'Jewelrys' bank.Changed:connect(function(prop) if prop == 'Transparency' then if bank.Transparency ~= 0 then print('Bank is open')end end end) jewelry.Changed:connect(function(prop)if prop == 'Transparency' then if jewelry.Transparency ~= 0 then print('Jewelry is open') end end end) print('Stores Ready To Rob: (If nothing shows, nothing is ready)') if GetFrom'Banks'.Transparency ~= 0 then print('Bank is open') end if GetFrom'Banks'.Transparency ~= 0 then print('Jewelry is open') end");
		}

		// Token: 0x0600007D RID: 125
		private void flatButton102_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(129.5, 18, 1324) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(127, 18, 1311) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-174, 22, 1600) + Vector3.new(1,0,0) wait(1.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(244, 22, 1366) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600007E RID: 126
		private void flatButton100_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(184.722824, 18, 1357.91418) + Vector3.new(1,0,0) wait(1.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(141.722824, 18, 1353.91418) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(141.722824, 18, 1343) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(125.722824, 18, 1330) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(113.722824, 18, 1335) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600007F RID: 127
		private void flatButton101_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(110.722824, 18, 1320) + Vector3.new(1,0,0) wait(0.15) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(120.722824, 18, 1317) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(137.722824, 18, 1317) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(135.5, 18, 1307) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(138.5, 18, 1324) + Vector3.new(1,0,0)");
		}

		// Token: 0x06000080 RID: 128
		private void flatCheckBox8_CheckedChanged(object sender)
		{
			if (!this.flatCheckBox8.Checked)
			{
				this.API.SendLuaScript("game:GetService('Workspace').Gravity = 196.2\nscript:Destroy()");
				return;
			}
			this.API.SendLuaScript("game:GetService('Workspace').Gravity = 0\nscript:Destroy()");
		}

		// Token: 0x06000081 RID: 129
		private void flatButton105_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
		}

		// Token: 0x06000082 RID: 130
		private void flatButton106_Click(object sender, EventArgs e)
		{
			this.API.SetJumpPower(100);
		}

		// Token: 0x06000083 RID: 131
		private void flatButton103_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox2.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x06000084 RID: 132
		private void flatButton104_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox5.Text;
			this.API.SetWalkSpeed(text, 100);
		}

		// Token: 0x06000085 RID: 133
		private void flatButton108_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x06000086 RID: 134
		private void flatButton110_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000087 RID: 135
		private void flatButton111_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local gui = Instance.new('BillboardGui'); gui.Name = ''; gui.AlwaysOnTop = true; gui.LightInfluence = 0; gui.Size = UDim2.new(1.75, 0, 1.75, 0); local frame = Instance.new('Frame', gui); frame.BackgroundColor3 = Color3.fromRGB(170, 0, 0); frame.Size = UDim2.new(1, 0, 1, 0); frame.BorderSizePixel = 4; frame.BorderColor3 = Color3.fromRGB(0, 0, 0); local gi = gui:Clone(); local body = frame:Clone(); body.Parent = gi; body.BackgroundColor3 = Color3.fromRGB(0, 170, 170); for _, v in pairs(game:GetService('Players'):GetPlayers()) do if v.Name ~= game:GetService('Players').LocalPlayer.Name and v.Character and v.Character:FindFirstChild('Torso') then gui:Clone().Parent = v.Character.Torso; end end local gui = Instance.new('BillboardGui'); gui.Name = ''; gui.AlwaysOnTop = true; gui.LightInfluence = 0; gui.Size = UDim2.new(1.25, 0, 1.25, 0); local frame = Instance.new('Frame', gui); frame.BackgroundColor3 = Color3.fromRGB(170, 0, 0); frame.Size = UDim2.new(0.75, 0, 0.75, 0); frame.BorderSizePixel = 4; frame.BorderColor3 = Color3.fromRGB(0, 0, 0); local gi = gui:Clone(); local body = frame:Clone(); body.Parent = gi; body.BackgroundColor3 = Color3.fromRGB(0, 170, 170); for _, v in pairs(game:GetService('Players'):GetPlayers()) do if v.Name ~= game:GetService('Players').LocalPlayer.Name and v.Character and v.Character:FindFirstChild('Head') then gui:Clone().Parent = v.Character.Head; end end");
		}

		// Token: 0x06000088 RID: 136
		private void flatButton107_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Click E to Toggle (Turn On/Off)");
			this.API.SendLuaScript("local Move = game.Workspace.Map local ReplicatedStorage = game:GetService('ReplicatedStorage') local Players = game:GetService('Players') local mouse = Players.LocalPlayer:GetMouse() local a = false mouse.KeyDown:Connect(function(key) if key == 'e' then if a == false then Move.Parent = ReplicatedStorage Players.LocalPlayer.Character.HumanoidRootPart.Anchored = true a = true elseif a == true then Move.Parent = game.Workspace Players.LocalPlayer.Character.HumanoidRootPart.Anchored = false a = false end end end)");
		}

		// Token: 0x06000089 RID: 137
		private void flatButton110_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Sell things in water to get more money");
			this.API.SendLuaScript("game.ReplicatedStorage.Connection:InvokeServer(9,2)game.ReplicatedStorage.Connection:InvokeServer(50)game.ReplicatedStorage.PlayerData[game.Players.LocalPlayer.UserId].PLUS.Value = true while wait() do game.ReplicatedStorage.Connection:InvokeServer(49)game.ReplicatedStorage.Connection:InvokeServer(51)end");
		}

		// Token: 0x0600008A RID: 138
		private void flatButton109_Click(object sender, EventArgs e)
		{
			this.API.SendLuaCScript(this.richTextBox6.Text);
		}

		// Token: 0x0600008B RID: 139
		private void flatButton112_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game.ReplicatedStorage.PlayerData[game.Players.LocalPlayer.UserId].ChalkPass.Value = true");
		}

		// Token: 0x0600008C RID: 140
		private void flatButton113_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game.ReplicatedStorage.PlayerData[game.Players.LocalPlayer.UserId].BoomBox.Value = true");
		}

		// Token: 0x0600008D RID: 141
		private void flatButton125_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-89, 3, -452) end");
		}

		// Token: 0x0600008E RID: 142
		private void flatButton124_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-88, 3.5, -150) end");
		}

		// Token: 0x0600008F RID: 143
		private void flatButton123_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(17.74, 3.35, 453.33) end");
		}

		// Token: 0x06000090 RID: 144
		private void flatButton122_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(18.19, 3.35, 144) end");
		}

		// Token: 0x06000091 RID: 145
		private void flatButton114_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame =  CFrame.new(-89.05, 3.35, 144) end");
		}

		// Token: 0x06000092 RID: 146
		private void flatButton119_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-86.08, 3.35, 446.63) end");
		}

		// Token: 0x06000093 RID: 147
		private void flatButton115_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-52.7326279, 3.45200205, -556.515015) end");
		}

		// Token: 0x06000094 RID: 148
		private void flatButton118_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(18.35, 3.35, 774.2) end");
		}

		// Token: 0x06000095 RID: 149
		private void flatButton116_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-14.55, 3.86, -558.21) end");
		}

		// Token: 0x06000096 RID: 150
		private void flatButton117_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.63, 3.35, -434.96) end");
		}

		// Token: 0x06000097 RID: 151
		private void flatButton120_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(16.23, 3.35, -152.98) end");
		}

		// Token: 0x06000098 RID: 152
		private void flatButton121_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-89.75, 3.35, 747.22) end");
		}

		// Token: 0x06000099 RID: 153
		private void flatButton129_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("Game.Workspace.LocalPlayer.Walkspeed = 100");
		}

		// Token: 0x0600009A RID: 154
		private void flatButton128_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("Game.Workspace.LocalPlayer.Walkspeed = 35");
		}

		// Token: 0x0600009B RID: 155
		private void flatButton127_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("Game.Workspace.LocalPlayer.Gravity = 100");
		}

		// Token: 0x0600009C RID: 156
		private void flatButton126_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("Game.Workspace.LocalPlayer.Gravity = 35");
		}

		// Token: 0x0600009D RID: 157
		private void flatButton136_Click(object sender, EventArgs e)
		{
			this.API.SendLuaCScript("getglobal game\ngetfield -1 Players\ngetfield -1 LocalPlayer\ngetfield -1 Character\ngetfield -1 HumanoidRootPart\ngetglobal CFrame\ngetfield -1 new\npushnumber -1585\npushnumber 622\npushnumber 1140\npcall 3 1 0\nsetfield -3 CFrame\ngetglobal game\ngetfield -1 Players\ngetfield -1 LocalPlayer\ngetfield -1 Character\ngetfield -1 HumanoidRootPart\ngetglobal CFrame\ngetfield -1 new\npushnumber -1585\npushnumber 622\npushnumber 1140\npcall 3 1 0\nsetfield -3 CFrame");
		}

		// Token: 0x0600009E RID: 158
		private void flatButton135_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox7.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x0600009F RID: 159
		private void flatButton134_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(3581, -179, 430)");
		}

		// Token: 0x060000A0 RID: 160
		private void flatButton133_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox8.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000A1 RID: 161
		private void flatButton140_Click(object sender, EventArgs e)
		{
			this.API.SendLuaCScript("getglobal game\r\ngetfield -1 Players\r\ngetfield -1 LocalPlayer\r\ngetfield -1 Character\r\ngetfield -1 HumanoidRootPart\r\ngetglobal CFrame\r\ngetfield -1 new\r\npushnumber 1114\r\npushnumber -1\r\npushnumber -197\r\npcall 3 1 0\r\nsetfield -3 CFrame");
		}

		// Token: 0x060000A2 RID: 162
		private void flatButton149_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(4604, -3, -727)");
		}

		// Token: 0x060000A3 RID: 163
		private void flatButton147_Click(object sender, EventArgs e)
		{
			this.API.SetJumpPower(100);
		}

		// Token: 0x060000A4 RID: 164
		private void flatButton146_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox5.Text;
			this.API.SetWalkSpeed(text, 100);
		}

		// Token: 0x060000A5 RID: 165
		private void flatButton138_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack, true)\nplr = game:GetService(\"Players\").LocalPlayer\nchar = plr.Character\nhum = char.Humanoid\ntool5 = Instance.new(\"HopperBin\", plr.Backpack)\ntool5.Name = \"click unlock\"\nmouse = plr:GetMouse()\n\ntool5.Selected:connect(function()\nmouse.Button1Down:connect(function()\nmouse.Target.Locked = false\nend)\nend)\nc = Instance.new(\"HopperBin\", game:GetService(\"Players\").LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Hammer");
		}

		// Token: 0x060000A6 RID: 166
		private void flatButton145_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox2.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x060000A7 RID: 167
		private void flatButton155_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(- 500, 45, -1150)");
		}

		// Token: 0x060000A8 RID: 168
		private void flatButton154_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1100, 45, -2700)");
		}

		// Token: 0x060000A9 RID: 169
		private void flatButton153_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-2900, 45, 900)");
		}

		// Token: 0x060000AA RID: 170
		private void flatButton152_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-3302, 45, 465)game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-3302, 45, 465)");
		}

		// Token: 0x060000AB RID: 171
		private void flatButton151_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-450, 45, -3550)");
		}

		// Token: 0x060000AC RID: 172
		private void flatButton157_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(2600, 91, -2800)");
		}

		// Token: 0x060000AD RID: 173
		private void flatButton156_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-2800, 45, -390)");
		}

		// Token: 0x060000AE RID: 174
		private void flatButton164_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-2000, 45, 1622)");
		}

		// Token: 0x060000AF RID: 175
		private void flatButton163_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1500, 45, 2500)");
		}

		// Token: 0x060000B0 RID: 176
		private void flatButton162_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-2950, 45, 150)");
		}

		// Token: 0x060000B1 RID: 177
		private void flatButton161_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1800, 45, -1200)");
		}

		// Token: 0x060000B2 RID: 178
		private void flatButton158_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(300, 45, 770)");
		}

		// Token: 0x060000B3 RID: 179
		private void flatButton159_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1500, 45, 470)");
		}

		// Token: 0x060000B4 RID: 180
		private void flatButton160_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Type /e speedhack to activate speedhack. Type /e stop to use AFK while driving at high speed. ");
			this.API.SendLuaScript("local plr = game.Players.LocalPlayer local inftoggle = false function getvehicle() for i,v in pairs(game.Workspace.Vehicles:GetChildren()) do if v:IsA('Model') then if v.owner.Value == plr.Name then return v end end end return nil end function hint(txt, t) if t then local h = Instance.new('Hint',plr.PlayerGui) h.Text = txt wait(t) h:remove() else local h = Instance.new('Hint',plr.PlayerGui) h.Text = txt wait(2) h:remove() end end plr.Chatted:connect(function(msg) if msg:lower():sub(1,10) == '/e toggle' then local ins = msg:lower():sub(11) local vehicle = getvehicle() if vehicle then if ins == 'infnitro' then if inftoggle == true then inftoggle = false hint('(-)Disabled Infinite Nitro!(-)') else inftoggle = true hint('(+)Enabled Infinite Nitro!(+)') end end else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,14) == '/e nitrospeed' then local num = msg:sub(15) local vehicle = getvehicle() if vehicle then vehicle.Handling.Nitro.NitroSpeed.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,14) == '/e stop' then local num = msg:sub(1,15) local vehicle = getvehicle() if vehicle then vehicle.Chassis.VehicleSeat.Anchored = true else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,14) == '/e nitroforce' then local num = msg:sub(1,15) local vehicle = getvehicle() if vehicle then vehicle.Handling.Nitro.NitroForce.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,12) == '/e maxspeed' then local num = msg:sub(13) local vehicle = getvehicle() if vehicle then vehicle.Handling.MaxSpeed.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,10) == '/e torque' then local num = msg:sub(11) local vehicle = getvehicle() if vehicle then vehicle.Handling.Torque.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,12) == '/e friction' then local num = msg:sub(13) local vehicle = getvehicle() if vehicle then vehicle.Handling.FrictionOffroad.Value = tonumber(num) vehicle.Handling.FrictionRoad.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,13) == '/e speedhack' then local vehicle = getvehicle() if vehicle then han = vehicle.Handling han.MaxSpeed.Value = 10000 han.Torque.Value = 30000 han.SteeringRadiusConstant.Value = 12000 han.FrictionOffroad.Value = 200 han.FrictionRoad.Value = 200 han.Nitro.NitroSpeed.Value = 300 han.Nitro.NitroForce.Value = 8000 han.TurboJump.TurboJumpHeight.Value = 300 inftoggle = true else hint('(-)You do not have a vehicle spawned!(-)') end end end) wait(0.5) while inftoggle == true do wait(0.02) local vehicle = getvehicle() if vehicle then vehicle.Handling.Nitro.NitroAmount.Value = 250 end end");
		}

		// Token: 0x060000B5 RID: 181
		private void flatButton165_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox9.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000B6 RID: 182
		private void flatButton169_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press F9 to check. ");
			this.API.SendLuaScript("for i,v in pairs(game.Players:GetChildren()) do if v.Backpack.Knife ~= nil or v.Character.Knife ~= nil then print(v.Name .. ' is murderer') end end for i,v in pairs(game.Players:GetChildren()) do if v.Backpack.Gun ~= nil or v.Backpack.Revolver ~= nil or v.Character.Gun ~= nil or v.Character.Revolver ~= nil then print(v.Name .. ' is sheriff') end end if workspace.GunDrop ~= nil then game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(workspace.GunDrop.Position) end");
		}

		// Token: 0x060000B7 RID: 183
		private void flatButton168_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B8 RID: 184
		private void flatButton166_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 1 local l = game:GetService('Players').LocalPlayer.Character['1']:Clone() l.Parent = game:GetService('Players').LocalPlayer.Character l.Name = 'Humanoid' wait(0.1) game:GetService('Players').LocalPlayer.Character['1']:Destroy() game:GetService('Workspace').CurrentCamera.CameraSubject = game:GetService('Players').LocalPlayer.Character game:GetService('Players').LocalPlayer.Character.Animate.Disabled = true wait(0.1) game:GetService('Players').LocalPlayer.Character.Animate.Disabled = false game:GetService('Players').LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
		}

		// Token: 0x060000B9 RID: 185
		private void flatButton167_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("while wait(1) do for i,v in pairs(game.Workspace:GetChildren()) do local f = v:FindFirstChild('CoinContainer') local q = game.Players.LocalPlayer.Character:FindFirstChild('Torso') if q and f then for i,c in pairs(f:GetChildren()) do c.CFrame = game.Players.LocalPlayer.Character.Torso.CFrame end end end end");
		}

		// Token: 0x060000BA RID: 186
		private void flatButton173_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox2.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x060000BB RID: 187
		private void flatButton170_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local name = game.Players.LocalPlayer.Name local plr = game.Workspace.Characters[name] for i, v in pairs(workspace['Crate_Spawns']:children()) do  v: MoveTo(plr.Head.Position + Vector3.new(math.random(-15, 15), 0, math.random(-15, 15))) end");
		}

		// Token: 0x060000BC RID: 188
		private void flatButton172_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press X to ON/OFF ESP");
			this.API.SendLuaScript("local ReplicatedStorage = game:GetService('ReplicatedStorage') local Players = game:GetService('Players') local mouse = Players.LocalPlayer:GetMouse() local a = false mouse.KeyDown:Connect(function(key)if key == 'x' then if a == false then pcall(function() game.Workspace.Map.Parent = ReplicatedStorage end) if game.Workspace:FindFirstChild('#elta') ~= nil then game.Workspace:WaitForChild('#elta'):Destroy() end local abc = Instance.new('Part', workspace) abc.Anchored = true abc.Name = '#elta' abc.Size = Vector3.new(2048, 1, 2048) abc.CFrame = CFrame.new(Players.LocalPlayer.Character.HumanoidRootPart.CFrame.X, Players.LocalPlayer.Character.HumanoidRootPart.CFrame.Y -10, Players.LocalPlayer.Character.HumanoidRootPart.CFrame.Z) a = true elseif a == true then pcall(function() ReplicatedStorage.Map.Parent = game.Workspace end) if game.Workspace:FindFirstChild('#elta') ~= nil then game.Workspace:WaitForChild('#elta'):Destroy() end a = false end end end)");
		}

		// Token: 0x060000BD RID: 189
		private void flatButton171_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftAlt) then return end if not Mouse.Target then return end Plr.Character:MoveTo(Mouse.Hit.p) end)");
		}

		// Token: 0x060000BE RID: 190
		private void flatButton174_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript(" local char = game:GetService('Players').LocalPlayer.Character local function collect(folder) for _,part in ipairs(folder:GetChildren()) do if part.Parent then char:MoveTo(part.Position) wait(0.5)end end end collect(workspace.TreasureCollectibles) collect(workspace.Treasures)");
		}

		// Token: 0x060000BF RID: 191
		private void flatButton189_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local plr = game:GetService'Players'.LocalPlayer local m = plr:GetMouse() m.KeyDown:connect(function(k) if k == ' ' then game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping') wait() game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Seated') end end)");
		}

		// Token: 0x060000C0 RID: 192
		private void flatButton185_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftAlt) then return end if not Mouse.Target then return end Plr.Character:MoveTo(Mouse.Hit.p) end)");
		}

		// Token: 0x060000C1 RID: 193
		private void flatButton181_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x060000C2 RID: 194
		private void flatButton188_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game.Workspace.Doors:Destroy()");
		}

		// Token: 0x060000C3 RID: 195
		private void flatButton184_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local weapons = {'Crude Knife', 'Sharpened stick', 'Extendo mirror'} for i, v in pairs(game.ReplicatedStorage.Tools:GetChildren()) do for j, k in pairs(weapons) do if v.Name == k then v:Clone().Parent = game.Players.LocalPlayer.Backpack end end end");
		}

		// Token: 0x060000C4 RID: 196
		private void flatButton180_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local mouse = game.Players.LocalPlayer:GetMouse() local arrestEvent = game.Workspace.Remote.arrest mouse.Button1Down:connect(function() local obj = mouse.Target local response = arrestEvent:InvokeServer(obj) end)");
		}

		// Token: 0x060000C5 RID: 197
		private void flatButton187_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local weapons = {'Remington 870', 'M9', 'AK-47', 'M4A1', 'Riot Shield'} for i, v in pairs(game.Workspace['Prison_ITEMS'].giver:GetChildren()) do for j, k in pairs(weapons) do if v.Name == k then v:MoveTo(game.Players.LocalPlayer.Character.Torso.Position) end end end");
		}

		// Token: 0x060000C6 RID: 198
		private void flatButton183_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 1 local l = game:GetService('Players').LocalPlayer.Character['1']:Clone() l.Parent = game:GetService('Players').LocalPlayer.Character l.Name = 'Humanoid' wait(0.1) game:GetService('Players').LocalPlayer.Character['1']:Destroy() game:GetService('Workspace').CurrentCamera.CameraSubject = game:GetService('Players').LocalPlayer.Character game:GetService('Players').LocalPlayer.Character.Animate.Disabled = true wait(0.1) game:GetService('Players').LocalPlayer.Character.Animate.Disabled = false game:GetService('Players').LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
		}

		// Token: 0x060000C7 RID: 199
		private void flatButton186_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("_G.WalkSpeed = 150 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
		}

		// Token: 0x060000C8 RID: 200
		private void flatButton182_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C9 RID: 201
		private void flatButton175_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new (283, 72, 2213)");
		}

		// Token: 0x060000CA RID: 202
		private void flatButton193_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x060000CB RID: 203
		private void flatButton198_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("local plr = game:GetService'Players'.LocalPlayer local m = plr:GetMouse() m.KeyDown:connect(function(k) if k == ' ' then game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping') wait() game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Seated') end end)");
		}

		// Token: 0x060000CC RID: 204
		private void flatButton190_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 1 local l = game:GetService('Players').LocalPlayer.Character['1']:Clone() l.Parent = game:GetService('Players').LocalPlayer.Character l.Name = 'Humanoid' wait(0.1) game:GetService('Players').LocalPlayer.Character['1']:Destroy() game:GetService('Workspace').CurrentCamera.CameraSubject = game:GetService('Players').LocalPlayer.Character game:GetService('Players').LocalPlayer.Character.Animate.Disabled = true wait(0.1) game:GetService('Players').LocalPlayer.Character.Animate.Disabled = false game:GetService('Players').LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
		}

		// Token: 0x060000CD RID: 205
		private void flatButton196_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CE RID: 206
		private void flatButton195_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press 'G' to use rainbow path.");
			this.API.SendLuaScript("local player = game:GetService('Players').LocalPlayer local mouse = player:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'g' or key:upper() == 'G' then for i = 1,6 do wait(0.25) x = Instance.new('Part',game:GetService('Workspace')) x.Size = Vector3.new(10,0.2,10) x.TopSurface = 'Smooth' x.Anchored = true x.BrickColor = BrickColor.random()  x.CFrame = CFrame.new(player.Character.UpperTorso.Position) + Vector3.new(0,-3,0) game.Debris:AddItem(x, 3) end end end)");
		}

		// Token: 0x060000CF RID: 207
		private void flatButton197_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
		}

		// Token: 0x060000D0 RID: 208
		private void flatButton191_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Workspace').Gravity = 196.2\nscript:Destroy()");
		}

		// Token: 0x060000D1 RID: 209
		private void flatButton192_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("_G.WalkSpeed = 150 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
		}

		// Token: 0x060000D2 RID: 210
		private void flatButton194_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("_G.WalkSpeed = 16 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
		}

		// Token: 0x060000D3 RID: 211
		private void flatButton200_Click(object sender, EventArgs e)
		{
			string text = this.flatTextBox5.Text;
			this.API.PlaySoundInGame(text);
		}

		// Token: 0x060000D4 RID: 212
		private void flatButton202_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox11.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000D5 RID: 213
		private void flatButton201_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox12.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000D6 RID: 214
		private void flatButton204_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox13.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000D7 RID: 215
		private void flatButton203_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox14.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000D8 RID: 216
		private void flatButton205_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox15.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000D9 RID: 217
		private void flatButton206_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox16.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000DA RID: 218
		private void flatButton207_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox17.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000DB RID: 219
		private void flatButton208_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox18.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000DC RID: 220
		private void flatButton210_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox19.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000DD RID: 221
		private void flatButton209_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox20.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000DE RID: 222
		private void flatButton211_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox21.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000DF RID: 223
		private void flatButton212_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox22.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000E0 RID: 224
		private void flatButton217_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox23.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000E1 RID: 225
		private void flatButton216_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox24.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000E2 RID: 226
		private void flatButton213_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox25.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000E3 RID: 227
		private void flatButton91_Click(object sender, EventArgs e)
		{
			this.API.SendLuaScript("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 1 local l = game:GetService('Players').LocalPlayer.Character['1']:Clone() l.Parent = game:GetService('Players').LocalPlayer.Character l.Name = 'Humanoid' wait(0.1) game:GetService('Players').LocalPlayer.Character['1']:Destroy() game:GetService('Workspace').CurrentCamera.CameraSubject = game:GetService('Players').LocalPlayer.Character game:GetService('Players').LocalPlayer.Character.Animate.Disabled = true wait(0.1) game:GetService('Players').LocalPlayer.Character.Animate.Disabled = false game:GetService('Players').LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
		}

		// Token: 0x060000E4 RID: 228
		private void flatButton199_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E5 RID: 229
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E6 RID: 230
		private void FlatButton214_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/tKXXpqW");
		}

		// Token: 0x060000E7 RID: 231
		private void FlatButton215_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Open the converter folder and use it");
		}

		// Token: 0x060000E8 RID: 232
		private void FlatLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E9 RID: 233
		private void FlatTextBox7_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000EA RID: 234
		private void FlatButton218_Click(object sender, EventArgs e)
		{
			this.API.SetFogEnd(20);
		}

		// Token: 0x060000EB RID: 235
		private void FlatButton219_Click(object sender, EventArgs e)
		{
			string text = this.flatTextBox6.Text;
			this.API.SetSkyboxImage(text);
		}

		// Token: 0x060000EC RID: 236
		private void FlatButton144_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000ED RID: 237
		private void FlatButton132_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000EE RID: 238
		private void FlatButton220_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Run the jailbreak script/commands first then once your done press this to erase all the hacks in jailbreak you used so you wont get banned in game!/Put in the cheater cage");
			string text = this.richTextBox27.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x060000EF RID: 239
		private void FlatButton221_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Using this cmd allows you to use the old jailbreak gui and not get kicked or use old noclip and not get kicked etc please note that this is not anti ban for jailbreak");
			string text = this.richTextBox28.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x060000F0 RID: 240
		private void FlatButton222_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox29.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x060000F1 RID: 241
		private void FlatButton223_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This only works with the honey badger and to activate just walk over any gun dropped by enemy to fill ammo");
			string text = this.richTextBox30.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x060000F2 RID: 242
		private void FlatButton224_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox31.Text;
			this.API.SendLuaScript(text);
		}

		// Token: 0x060000F3 RID: 243
		private void FlatButton225_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F4 RID: 244
		private void FlatButton225_Click_1(object sender, EventArgs e)
		{
			string text = this.richTextBox32.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000F5 RID: 245
		private void FlatButton226_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox33.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000F6 RID: 246
		private void FlatButton228_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This element is azicorn");
			string text = this.richTextBox34.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000F7 RID: 247
		private void FlatButton227_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox35.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000F8 RID: 248
		private void FlatButton229_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Make sure u in the factory obby");
			string text = this.richTextBox36.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000F9 RID: 249
		private void FlatButton230_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Doesnt save all states");
			string text = this.richTextBox38.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x060000FA RID: 250
		private void FlatButton231_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Also gives u level per kill");
			string text = this.richTextBox37.Text;
			this.API.SendLuaCScript(text);
		}

		// Token: 0x04000001 RID: 1
		private ExploitAPI API = new ExploitAPI();

		// Token: 0x04000002 RID: 2
		private int int_0;

        private void FlatTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
