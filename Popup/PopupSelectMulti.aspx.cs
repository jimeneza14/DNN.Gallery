using DotNetNuke;
using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities;
using DotNetNuke.Framework;
using DotNetNuke.Security;
using DotNetNuke.Services;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;
using System.Web.SessionState;
using System.Web.Security;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2011 by DotNetNuke Corp. 

//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
//




namespace DotNetNuke.Modules.Gallery.PopupControls
{

	partial class PopupSelectMulti : PopupPageBase
	{

		//Inherits DotNetNuke.Framework.PageBase
		//'Changed Inherits System.Web.UI.Page to DNN Framework PageBase by M. Schlomann

		public string PageTitle = "";
		public string Appendtxt = "";
		public string Appendinfo = "";
		public string Removeinfo = "";
		public string Removetxt = "";
		public string btnOK = "";
		public string btnCancel = "";

		public string SelectRecords = "";

		#region " Web Form Designer Generated Code "

		//This call is required by the Web Form Designer.
		[System.Diagnostics.DebuggerStepThrough()]

		private void InitializeComponent()
		{
		}

		//Protected WithEvents btnTest As System.Web.UI.WebControls.Button
		//Protected WithEvents Button1 As System.Web.UI.HtmlControls.HtmlButton
		//Protected WithEvents Button2 As System.Web.UI.HtmlControls.HtmlButton
		//Protected WithEvents ctlSearch As DotNetNuke.Modules.Gallery.PopupControls.PopupSearch
		//Protected WithEvents ctlSearch As DotNetNuke.Modules.Gallery.PopupControls.PopupSearch

		//NOTE: The following placeholder declaration is required by the Web Form Designer.
		//Do not delete or move it.

		private System.Object designerPlaceholderDeclaration;
		private void Page_Init(System.Object sender, System.EventArgs e)
		{
			//CODEGEN: This method call is required by the Web Form Designer
			//Do not modify it using the code editor.
			InitializeComponent();
		}

		#endregion


		private void Page_Load(System.Object sender, System.EventArgs e)
		{
			//Put user code to initialize the page here

			ctlSearch.PortalID = PortalSettings.PortalId;

			//Localization  added by M. Schlomann/William Severance
			PageTitle = Localization.GetString("_Title", LocalResourceFile);
			Appendtxt = Localization.GetString("btnAppend_text", LocalResourceFile);
			Appendinfo = Localization.GetString("btnAppend_info", LocalResourceFile);
			Removetxt = Localization.GetString("btnRemove_text", LocalResourceFile);
			Removeinfo = Localization.GetString("btnRemove_info", LocalResourceFile);
			btnOK = Localization.GetString("btnOK_text", LocalResourceFile);
			btnCancel = Localization.GetString("btnCancel_text", LocalResourceFile);
			SelectRecords = Localization.GetString("SelectRecords_text", LocalResourceFile);
		}

	}

}
