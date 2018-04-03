using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;


namespace CFSTests
{
	/// <summary>
	/// Summary description for CodedUITest1
	/// </summary>
	[CodedUITest]
	public class SubmitLoanApplicationTest
	{
		public SubmitLoanApplicationTest()
		{
		}

		[DeploymentItem("Example 3.2 file.fnm"), TestMethod]
		//[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
		public void SubmitLoanApplicationTestMethod1()
		{
			
			int syncTime = 20000;
			// To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
			this.UIMap.Open_Browser_And_Navigate();
			this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument.WaitForControlReady(syncTime);
			if (this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument.UIUsernameEdit.WaitForControlExist(syncTime))
			{
				//this.UIMap.Enter_UsernameParams.UIUsernameEditText = TestContext.DataRow["username"].ToString();
				this.UIMap.Enter_Username();
				Console.WriteLine("Entered username as " + this.UIMap.Enter_UsernameParams.UIUsernameEditText);
			}
			else
			{
				this.UIMap.Logout_User();
				Assert.Fail("Username field is not displayed");
			}

			if (this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument.UIPasswordEdit.WaitForControlExist(syncTime))
			{
				//this.UIMap.Enter_PasswordParams.UIPasswordEditPassword = TestContext.DataRow["password"].ToString();
				this.UIMap.Enter_Password();
				Console.WriteLine("Entered Password");
			}
			else
			{
				this.UIMap.Logout_User();
				Assert.Fail("Password field is not displayed");
			}

			if (this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument.UICtrlauthFormCustom.UILOGINButton.WaitForControlExist(syncTime))
			{
				this.UIMap.Click_On_Login_Button();
				Console.WriteLine("Clicked on login button");
			}
			else
			{
				this.UIMap.Logout_User();
				Assert.Fail("Login button is not displayed");
			}

			this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument1.WaitForControlReady(syncTime);
			this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument1.UIHiCIVICButton.WaitForControlExist(syncTime);
			this.UIMap.Verify_Whether_Login_Name_Is_Displayed_Or_Not();
			Console.WriteLine("Verified whether username is displayed or not");
			if (this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument1.UINavbartwoPane.UISUBMITHyperlink.WaitForControlExist(syncTime))
			{
				this.UIMap.Click_On_Submit_Menu_Link();
				Console.WriteLine("Clicked on Subimt Menu Link");
			}
			else
			{
				this.UIMap.Logout_User();
				Assert.Fail("Submit Menu link is not displayed");
			}

			if (this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument2.UIItem32UPLOADButton.WaitForControlExist(syncTime))
			{
				this.UIMap.Click_On_32_Upload_Button();
				Console.WriteLine("Clicked on 3.2Upload button");
			}
			else
			{
				this.UIMap.Logout_User();
				Assert.Fail("3.2 Upload button is not displayed");
			}

			if (this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument2.UIBrowsePane.WaitForControlExist(syncTime))
			{
				this.UIMap.Provide_File_Name();
				Console.WriteLine("Provied Filename");
			}
			else
			{
				this.UIMap.Logout_User();
				Assert.Fail("File browser window is not displayed");
			}

			if (this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument2.UIUPLOADFILEButton.WaitForControlExist(syncTime))
			{
				this.UIMap.Click_On_Upload_File_Button();
				Console.WriteLine("Clicked on UpLoad File Button");
			}
			else
			{
				this.UIMap.Logout_User();
				Assert.Fail("Upload File button is not displayed");
			}

			if (this.UIMap.UIHomeCivicClientPortaWindow.UIHomeCivicClientPortaDocument2.UIHiCIVICButton.WaitForControlExist(syncTime))
			{
				this.UIMap.Logout_User();
				Console.WriteLine("Logout from the application");
			}
			else
			{
				Assert.Fail("User drop down is not displayed");
			}
			
		}

		#region Additional test attributes

		// You can use the following additional attributes as you write your tests:

		////Use TestInitialize to run code before running each test 
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{        
		//    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
		//}

		////Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{        
		//    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
		//}

		#endregion

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}
		private TestContext testContextInstance;

		public UIMap UIMap
		{
			get
			{
				if ((this.map == null))
				{
					this.map = new UIMap();
				}

				return this.map;
			}
		}

		private UIMap map;
	}
}
