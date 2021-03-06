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

namespace AgileMind.Website.GamesScoreWS {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="GameScoreServiceSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedEnd))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuralObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Result))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(t_GameResults[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityKeyMember[]))]
    public partial class GameScoreService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback FetchUserGameResultsOperationCompleted;
        
        private System.Threading.SendOrPostCallback FetchIndividualGamesOperationCompleted;
        
        private System.Threading.SendOrPostCallback FetchGameListOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GameScoreService() {
            this.Url = global::AgileMind.Website.Properties.Settings.Default.AgileMind_Website_GamesScoreWS_GameScoreService;
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
        public event FetchUserGameResultsCompletedEventHandler FetchUserGameResultsCompleted;
        
        /// <remarks/>
        public event FetchIndividualGamesCompletedEventHandler FetchIndividualGamesCompleted;
        
        /// <remarks/>
        public event FetchGameListCompletedEventHandler FetchGameListCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FetchUserGameResults", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UserGameResults FetchUserGameResults(System.Guid SessionId) {
            object[] results = this.Invoke("FetchUserGameResults", new object[] {
                        SessionId});
            return ((UserGameResults)(results[0]));
        }
        
        /// <remarks/>
        public void FetchUserGameResultsAsync(System.Guid SessionId) {
            this.FetchUserGameResultsAsync(SessionId, null);
        }
        
        /// <remarks/>
        public void FetchUserGameResultsAsync(System.Guid SessionId, object userState) {
            if ((this.FetchUserGameResultsOperationCompleted == null)) {
                this.FetchUserGameResultsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFetchUserGameResultsOperationCompleted);
            }
            this.InvokeAsync("FetchUserGameResults", new object[] {
                        SessionId}, this.FetchUserGameResultsOperationCompleted, userState);
        }
        
        private void OnFetchUserGameResultsOperationCompleted(object arg) {
            if ((this.FetchUserGameResultsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FetchUserGameResultsCompleted(this, new FetchUserGameResultsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FetchIndividualGames", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public IndividualGameResults FetchIndividualGames(System.Guid SessionId, int GameId) {
            object[] results = this.Invoke("FetchIndividualGames", new object[] {
                        SessionId,
                        GameId});
            return ((IndividualGameResults)(results[0]));
        }
        
        /// <remarks/>
        public void FetchIndividualGamesAsync(System.Guid SessionId, int GameId) {
            this.FetchIndividualGamesAsync(SessionId, GameId, null);
        }
        
        /// <remarks/>
        public void FetchIndividualGamesAsync(System.Guid SessionId, int GameId, object userState) {
            if ((this.FetchIndividualGamesOperationCompleted == null)) {
                this.FetchIndividualGamesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFetchIndividualGamesOperationCompleted);
            }
            this.InvokeAsync("FetchIndividualGames", new object[] {
                        SessionId,
                        GameId}, this.FetchIndividualGamesOperationCompleted, userState);
        }
        
        private void OnFetchIndividualGamesOperationCompleted(object arg) {
            if ((this.FetchIndividualGamesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FetchIndividualGamesCompleted(this, new FetchIndividualGamesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FetchGameList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GameListResults FetchGameList(System.Guid SessionId) {
            object[] results = this.Invoke("FetchGameList", new object[] {
                        SessionId});
            return ((GameListResults)(results[0]));
        }
        
        /// <remarks/>
        public void FetchGameListAsync(System.Guid SessionId) {
            this.FetchGameListAsync(SessionId, null);
        }
        
        /// <remarks/>
        public void FetchGameListAsync(System.Guid SessionId, object userState) {
            if ((this.FetchGameListOperationCompleted == null)) {
                this.FetchGameListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFetchGameListOperationCompleted);
            }
            this.InvokeAsync("FetchGameList", new object[] {
                        SessionId}, this.FetchGameListOperationCompleted, userState);
        }
        
        private void OnFetchGameListOperationCompleted(object arg) {
            if ((this.FetchGameListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FetchGameListCompleted(this, new FetchGameListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class UserGameResults : Result {
        
        private UserMeanGameScore[] meanGameScoresField;
        
        private decimal userScoreField;
        
        /// <remarks/>
        public UserMeanGameScore[] MeanGameScores {
            get {
                return this.meanGameScoresField;
            }
            set {
                this.meanGameScoresField = value;
            }
        }
        
        /// <remarks/>
        public decimal UserScore {
            get {
                return this.userScoreField;
            }
            set {
                this.userScoreField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UserMeanGameScore {
        
        private decimal userMeanField;
        
        private int gameIdField;
        
        private string gameField;
        
        private decimal gameMeanField;
        
        private decimal gameDeviationField;
        
        private decimal meanDiffField;
        
        private decimal userDeflectionField;
        
        /// <remarks/>
        public decimal UserMean {
            get {
                return this.userMeanField;
            }
            set {
                this.userMeanField = value;
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
        public string Game {
            get {
                return this.gameField;
            }
            set {
                this.gameField = value;
            }
        }
        
        /// <remarks/>
        public decimal GameMean {
            get {
                return this.gameMeanField;
            }
            set {
                this.gameMeanField = value;
            }
        }
        
        /// <remarks/>
        public decimal GameDeviation {
            get {
                return this.gameDeviationField;
            }
            set {
                this.gameDeviationField = value;
            }
        }
        
        /// <remarks/>
        public decimal MeanDiff {
            get {
                return this.meanDiffField;
            }
            set {
                this.meanDiffField = value;
            }
        }
        
        /// <remarks/>
        public decimal UserDeflection {
            get {
                return this.userDeflectionField;
            }
            set {
                this.userDeflectionField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(t_Game))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(t_GameResults))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class StructuralObject {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(t_Game))]
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
    public partial class t_Game : EntityObject {
        
        private int gameIdField;
        
        private string gameField;
        
        private string descriptionField;
        
        private double meanField;
        
        private double stdevField;
        
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
        public string Game {
            get {
                return this.gameField;
            }
            set {
                this.gameField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public double Mean {
            get {
                return this.meanField;
            }
            set {
                this.meanField = value;
            }
        }
        
        /// <remarks/>
        public double stdev {
            get {
                return this.stdevField;
            }
            set {
                this.stdevField = value;
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GameListResults))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IndividualGameResults))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserGameResults))]
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
    public partial class GameListResults : Result {
        
        private t_Game[] gameListField;
        
        /// <remarks/>
        public t_Game[] GameList {
            get {
                return this.gameListField;
            }
            set {
                this.gameListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class IndividualGameResults : Result {
        
        private t_GameResults[] gameResultListField;
        
        /// <remarks/>
        public t_GameResults[] GameResultList {
            get {
                return this.gameResultListField;
            }
            set {
                this.gameResultListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void FetchUserGameResultsCompletedEventHandler(object sender, FetchUserGameResultsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FetchUserGameResultsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FetchUserGameResultsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UserGameResults Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UserGameResults)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void FetchIndividualGamesCompletedEventHandler(object sender, FetchIndividualGamesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FetchIndividualGamesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FetchIndividualGamesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public IndividualGameResults Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((IndividualGameResults)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void FetchGameListCompletedEventHandler(object sender, FetchGameListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FetchGameListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FetchGameListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GameListResults Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GameListResults)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591