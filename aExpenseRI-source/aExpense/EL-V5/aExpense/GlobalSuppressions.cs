#region license
// ==============================================================================
// Microsoft patterns & practices Enterprise Library
// aExpense Reference Implementation
// ==============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// ==============================================================================
#endregion

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "member", Target = "AExpense.ContainerBootstrapper.#Configure(Microsoft.Practices.Unity.IUnityContainer)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "AExpense.Default.#MyExpensesGridViewOnRowCommand(System.Object,System.Web.UI.WebControls.GridViewCommandEventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "AExpense.DataAccessLayer.ExpenseRepository.#.ctor(System.String,System.TimeSpan,Microsoft.Practices.EnterpriseLibrary.Caching.ICacheManager)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "AExpense.Global.#Application_Error(System.Object,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "AExpense.Global.#Application_PostAuthenticateRequest(System.Object,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Login", Scope = "member", Target = "AExpense.Site.#LoginStatusOnLoggedOut(System.Object,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "AExpense.ValidApproverCallHandler.#Invoke(Microsoft.Practices.Unity.InterceptionExtension.IMethodInvocation,Microsoft.Practices.Unity.InterceptionExtension.GetNextHandlerDelegate)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "AExpense.ValidApproverCallHandler.#Invoke(Microsoft.Practices.Unity.InterceptionExtension.IMethodInvocation,Microsoft.Practices.Unity.InterceptionExtension.GetNextHandlerDelegate)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "System.Web.UI.WebControls.ListItem.#ctor(System.String,System.String)", Scope = "member", Target = "AExpense.AddExpense.#InitializeControls()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "AExpense.DataAccessLayer.Expense.#ExpenseDetails")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "AExpense.DataAccessLayer.ExpenseDetail.#ReceiptThumbnailUrl")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "AExpense.DataAccessLayer.ExpenseDetail.#ReceiptUrl")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "AExpense.DataAccessLayer.IExpenseRepository.#GetAllExpenses()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Login", Scope = "member", Target = "AExpense.Site.#LoginStatus1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "AExpense.DataAccessLayer.ExpenseRepository.#exManager")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "AExpense.TracingBehavior.#Invoke(Microsoft.Practices.Unity.InterceptionExtension.IMethodInvocation,Microsoft.Practices.Unity.InterceptionExtension.GetNextInterceptionBehaviorDelegate)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "AExpense.TracingBehavior.#Invoke(Microsoft.Practices.Unity.InterceptionExtension.IMethodInvocation,Microsoft.Practices.Unity.InterceptionExtension.GetNextInterceptionBehaviorDelegate)")]
