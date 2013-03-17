﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18033.
// 
#pragma warning disable 1591

namespace AgileMind.Website.GamesWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GamesServiceSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedEnd))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuralObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Result))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityKeyMember[]))]
    public partial class GamesService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback FetchColorGameOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertGameResultOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertGameResultWebOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GamesService() {
            this.Url = global::AgileMind.Website.Properties.Settings.Default.AgileMind_Website_GamesWS_GamesService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event FetchColorGameCompletedEventHandler FetchColorGameCompleted;
        
        /// <remarks/>
        public event InsertGameResultCompletedEventHandler InsertGameResultCompleted;
        
        /// <remarks/>
        public event InsertGameResultWebCompletedEventHandler InsertGameResultWebCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FetchColorGame", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ColorGameResult FetchColorGame() {
            object[] results = this.Invoke("FetchColorGame", new object[0]);
            return ((ColorGameResult)(results[0]));
        }
        
        /// <remarks/>
        public void FetchColorGameAsync() {
            this.FetchColorGameAsync(null);
        }
        
        /// <remarks/>
        public void FetchColorGameAsync(object userState) {
            if ((this.FetchColorGameOperationCompleted == null)) {
                this.FetchColorGameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFetchColorGameOperationCompleted);
            }
            this.InvokeAsync("FetchColorGame", new object[0], this.FetchColorGameOperationCompleted, userState);
        }
        
        private void OnFetchColorGameOperationCompleted(object arg) {
            if ((this.FetchColorGameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FetchColorGameCompleted(this, new FetchColorGameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertGameResult", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GameResults InsertGameResult(string UserName, string Password, GameListEnum gameType, int Score, decimal TestDuration, int Total) {
            object[] results = this.Invoke("InsertGameResult", new object[] {
                        UserName,
                        Password,
                        gameType,
                        Score,
                        TestDuration,
                        Total});
            return ((GameResults)(results[0]));
        }
        
        /// <remarks/>
        public void InsertGameResultAsync(string UserName, string Password, GameListEnum gameType, int Score, decimal TestDuration, int Total) {
            this.InsertGameResultAsync(UserName, Password, gameType, Score, TestDuration, Total, null);
        }
        
        /// <remarks/>
        public void InsertGameResultAsync(string UserName, string Password, GameListEnum gameType, int Score, decimal TestDuration, int Total, object userState) {
            if ((this.InsertGameResultOperationCompleted == null)) {
                this.InsertGameResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertGameResultOperationCompleted);
            }
            this.InvokeAsync("InsertGameResult", new object[] {
                        UserName,
                        Password,
                        gameType,
                        Score,
                        TestDuration,
                        Total}, this.InsertGameResultOperationCompleted, userState);
        }
        
        private void OnInsertGameResultOperationCompleted(object arg) {
            if ((this.InsertGameResultCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertGameResultCompleted(this, new InsertGameResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertGameResultWeb", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GameResults InsertGameResultWeb(string UserName, GameListEnum gameType, int Score, decimal TestDuration, int Total) {
            object[] results = this.Invoke("InsertGameResultWeb", new object[] {
                        UserName,
                        gameType,
                        Score,
                        TestDuration,
                        Total});
            return ((GameResults)(results[0]));
        }
        
        /// <remarks/>
        public void InsertGameResultWebAsync(string UserName, GameListEnum gameType, int Score, decimal TestDuration, int Total) {
            this.InsertGameResultWebAsync(UserName, gameType, Score, TestDuration, Total, null);
        }
        
        /// <remarks/>
        public void InsertGameResultWebAsync(string UserName, GameListEnum gameType, int Score, decimal TestDuration, int Total, object userState) {
            if ((this.InsertGameResultWebOperationCompleted == null)) {
                this.InsertGameResultWebOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertGameResultWebOperationCompleted);
            }
            this.InvokeAsync("InsertGameResultWeb", new object[] {
                        UserName,
                        gameType,
                        Score,
                        TestDuration,
                        Total}, this.InsertGameResultWebOperationCompleted, userState);
        }
        
        private void OnInsertGameResultWebOperationCompleted(object arg) {
            if ((this.InsertGameResultWebCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertGameResultWebCompleted(this, new InsertGameResultWebCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ColorGameResult : Result {
        
        private ColorGameQuestion[] questionsField;
        
        /// <remarks/>
        public ColorGameQuestion[] Questions {
            get {
                return this.questionsField;
            }
            set {
                this.questionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ColorGameQuestion {
        
        private string leftWordField;
        
        private string leftColorField;
        
        private string rightWordField;
        
        private string rightColorField;
        
        private bool isMatchField;
        
        private bool userCorrectField;
        
        /// <remarks/>
        public string LeftWord {
            get {
                return this.leftWordField;
            }
            set {
                this.leftWordField = value;
            }
        }
        
        /// <remarks/>
        public string LeftColor {
            get {
                return this.leftColorField;
            }
            set {
                this.leftColorField = value;
            }
        }
        
        /// <remarks/>
        public string RightWord {
            get {
                return this.rightWordField;
            }
            set {
                this.rightWordField = value;
            }
        }
        
        /// <remarks/>
        public string RightColor {
            get {
                return this.rightColorField;
            }
            set {
                this.rightColorField = value;
            }
        }
        
        /// <remarks/>
        public bool IsMatch {
            get {
                return this.isMatchField;
            }
            set {
                this.isMatchField = value;
            }
        }
        
        /// <remarks/>
        public bool UserCorrect {
            get {
                return this.userCorrectField;
            }
            set {
                this.userCorrectField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReference))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReferenceOft_Game))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReferenceOfLogin))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class RelatedEnd {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReferenceOft_Game))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityReferenceOfLogin))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class EntityReference : RelatedEnd {
        
        private EntityKey entityKeyField;
        
        /// <remarks/>
        public EntityKey EntityKey {
            get {
                return this.entityKeyField;
            }
            set {
                this.entityKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityKey {
        
        private string entitySetNameField;
        
        private string entityContainerNameField;
        
        private EntityKeyMember[] entityKeyValuesField;
        
        /// <remarks/>
        public string EntitySetName {
            get {
                return this.entitySetNameField;
            }
            set {
                this.entitySetNameField = value;
            }
        }
        
        /// <remarks/>
        public string EntityContainerName {
            get {
                return this.entityContainerNameField;
            }
            set {
                this.entityContainerNameField = value;
            }
        }
        
        /// <remarks/>
        public EntityKeyMember[] EntityKeyValues {
            get {
                return this.entityKeyValuesField;
            }
            set {
                this.entityKeyValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityKeyMember {
        
        private string keyField;
        
        private object valueField;
        
        /// <remarks/>
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public object Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityReferenceOft_Game : EntityReference {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityReferenceOfLogin : EntityReference {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(t_GameResults))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class StructuralObject {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(t_GameResults))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class EntityObject : StructuralObject {
        
        private EntityKey entityKeyField;
        
        /// <remarks/>
        public EntityKey EntityKey {
            get {
                return this.entityKeyField;
            }
            set {
                this.entityKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class t_GameResults : EntityObject {
        
        private int gameScoreIdField;
        
        private int gameIdField;
        
        private int loginIdField;
        
        private System.DateTime createdField;
        
        private int scoreField;
        
        private int totalField;
        
        private System.Nullable<decimal> testDurationField;
        
        private EntityReferenceOfLogin loginReferenceField;
        
        private EntityReferenceOft_Game t_GameReferenceField;
        
        /// <remarks/>
        public int GameScoreId {
            get {
                return this.gameScoreIdField;
            }
            set {
                this.gameScoreIdField = value;
            }
        }
        
        /// <remarks/>
        public int GameId {
            get {
                return this.gameIdField;
            }
            set {
                this.gameIdField = value;
            }
        }
        
        /// <remarks/>
        public int LoginId {
            get {
                return this.loginIdField;
            }
            set {
                this.loginIdField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }
        
        /// <remarks/>
        public int Score {
            get {
                return this.scoreField;
            }
            set {
                this.scoreField = value;
            }
        }
        
        /// <remarks/>
        public int Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> TestDuration {
            get {
                return this.testDurationField;
            }
            set {
                this.testDurationField = value;
            }
        }
        
        /// <remarks/>
        public EntityReferenceOfLogin LoginReference {
            get {
                return this.loginReferenceField;
            }
            set {
                this.loginReferenceField = value;
            }
        }
        
        /// <remarks/>
        public EntityReferenceOft_Game t_GameReference {
            get {
                return this.t_GameReferenceField;
            }
            set {
                this.t_GameReferenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GameResults))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ColorGameResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Result {
        
        private bool successField;
        
        private string errorField;
        
        /// <remarks/>
        public bool Success {
            get {
                return this.successField;
            }
            set {
                this.successField = value;
            }
        }
        
        /// <remarks/>
        public string Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class GameResults : Result {
        
        private t_GameResults gameField;
        
        /// <remarks/>
        public t_GameResults Game {
            get {
                return this.gameField;
            }
            set {
                this.gameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum GameListEnum {
        
        /// <remarks/>
        ColorQuiz,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void FetchColorGameCompletedEventHandler(object sender, FetchColorGameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FetchColorGameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FetchColorGameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ColorGameResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ColorGameResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void InsertGameResultCompletedEventHandler(object sender, InsertGameResultCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertGameResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertGameResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GameResults Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GameResults)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void InsertGameResultWebCompletedEventHandler(object sender, InsertGameResultWebCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertGameResultWebCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertGameResultWebCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GameResults Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GameResults)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591