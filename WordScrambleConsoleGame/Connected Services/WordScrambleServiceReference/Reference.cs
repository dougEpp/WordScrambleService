﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WordScrambleConsoleGame.WordScrambleServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GameAlreadyHostedFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
    [System.SerializableAttribute()]
    public partial class GameAlreadyHostedFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HostNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HostName {
            get {
                return this.HostNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HostNameField, value) != true)) {
                    this.HostNameField = value;
                    this.RaisePropertyChanged("HostName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Word", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
    [System.SerializableAttribute()]
    public partial class Word : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ScrambledWordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnscrambledWordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ScrambledWord {
            get {
                return this.ScrambledWordField;
            }
            set {
                if ((object.ReferenceEquals(this.ScrambledWordField, value) != true)) {
                    this.ScrambledWordField = value;
                    this.RaisePropertyChanged("ScrambledWord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UnscrambledWord {
            get {
                return this.UnscrambledWordField;
            }
            set {
                if ((object.ReferenceEquals(this.UnscrambledWordField, value) != true)) {
                    this.UnscrambledWordField = value;
                    this.RaisePropertyChanged("UnscrambledWord");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MaxPlayersReachedFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
    [System.SerializableAttribute()]
    public partial class MaxPlayersReachedFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GameNotHostedFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
    [System.SerializableAttribute()]
    public partial class GameNotHostedFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlayerIsHostFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
    [System.SerializableAttribute()]
    public partial class PlayerIsHostFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HostNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HostName {
            get {
                return this.HostNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HostNameField, value) != true)) {
                    this.HostNameField = value;
                    this.RaisePropertyChanged("HostName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlayerNotInGameFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
    [System.SerializableAttribute()]
    public partial class PlayerNotInGameFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WordScrambleServiceReference.IWordScrambleService")]
    public interface IWordScrambleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/IsGameBeingHosted", ReplyAction="http://tempuri.org/IWordScrambleService/IsGameBeingHostedResponse")]
        bool IsGameBeingHosted();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/IsGameBeingHosted", ReplyAction="http://tempuri.org/IWordScrambleService/IsGameBeingHostedResponse")]
        System.Threading.Tasks.Task<bool> IsGameBeingHostedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/HostGame", ReplyAction="http://tempuri.org/IWordScrambleService/HostGameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WordScrambleConsoleGame.WordScrambleServiceReference.GameAlreadyHostedFault), Action="http://tempuri.org/IWordScrambleService/HostGameGameAlreadyHostedFaultFault", Name="GameAlreadyHostedFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
        string HostGame(string userName, string wordToScramble);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/HostGame", ReplyAction="http://tempuri.org/IWordScrambleService/HostGameResponse")]
        System.Threading.Tasks.Task<string> HostGameAsync(string userName, string wordToScramble);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/Join", ReplyAction="http://tempuri.org/IWordScrambleService/JoinResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WordScrambleConsoleGame.WordScrambleServiceReference.MaxPlayersReachedFault), Action="http://tempuri.org/IWordScrambleService/JoinMaxPlayersReachedFaultFault", Name="MaxPlayersReachedFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
        [System.ServiceModel.FaultContractAttribute(typeof(WordScrambleConsoleGame.WordScrambleServiceReference.GameNotHostedFault), Action="http://tempuri.org/IWordScrambleService/JoinGameNotHostedFaultFault", Name="GameNotHostedFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
        [System.ServiceModel.FaultContractAttribute(typeof(WordScrambleConsoleGame.WordScrambleServiceReference.PlayerIsHostFault), Action="http://tempuri.org/IWordScrambleService/JoinPlayerIsHostFaultFault", Name="PlayerIsHostFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
        WordScrambleConsoleGame.WordScrambleServiceReference.Word Join(string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/Join", ReplyAction="http://tempuri.org/IWordScrambleService/JoinResponse")]
        System.Threading.Tasks.Task<WordScrambleConsoleGame.WordScrambleServiceReference.Word> JoinAsync(string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/GuessWord", ReplyAction="http://tempuri.org/IWordScrambleService/GuessWordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WordScrambleConsoleGame.WordScrambleServiceReference.PlayerNotInGameFault), Action="http://tempuri.org/IWordScrambleService/GuessWordPlayerNotInGameFaultFault", Name="PlayerNotInGameFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
        [System.ServiceModel.FaultContractAttribute(typeof(WordScrambleConsoleGame.WordScrambleServiceReference.GameNotHostedFault), Action="http://tempuri.org/IWordScrambleService/GuessWordGameNotHostedFaultFault", Name="GameNotHostedFault", Namespace="http://schemas.datacontract.org/2004/07/WordScrambleService")]
        bool GuessWord(string playerName, string guessedWord, string unscrambledWord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/GuessWord", ReplyAction="http://tempuri.org/IWordScrambleService/GuessWordResponse")]
        System.Threading.Tasks.Task<bool> GuessWordAsync(string playerName, string guessedWord, string unscrambledWord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/LogOut", ReplyAction="http://tempuri.org/IWordScrambleService/LogOutResponse")]
        void LogOut(string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/LogOut", ReplyAction="http://tempuri.org/IWordScrambleService/LogOutResponse")]
        System.Threading.Tasks.Task LogOutAsync(string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/EndGame", ReplyAction="http://tempuri.org/IWordScrambleService/EndGameResponse")]
        void EndGame(string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScrambleService/EndGame", ReplyAction="http://tempuri.org/IWordScrambleService/EndGameResponse")]
        System.Threading.Tasks.Task EndGameAsync(string playerName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWordScrambleServiceChannel : WordScrambleConsoleGame.WordScrambleServiceReference.IWordScrambleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WordScrambleServiceClient : System.ServiceModel.ClientBase<WordScrambleConsoleGame.WordScrambleServiceReference.IWordScrambleService>, WordScrambleConsoleGame.WordScrambleServiceReference.IWordScrambleService {
        
        public WordScrambleServiceClient() {
        }
        
        public WordScrambleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WordScrambleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WordScrambleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WordScrambleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool IsGameBeingHosted() {
            return base.Channel.IsGameBeingHosted();
        }
        
        public System.Threading.Tasks.Task<bool> IsGameBeingHostedAsync() {
            return base.Channel.IsGameBeingHostedAsync();
        }
        
        public string HostGame(string userName, string wordToScramble) {
            return base.Channel.HostGame(userName, wordToScramble);
        }
        
        public System.Threading.Tasks.Task<string> HostGameAsync(string userName, string wordToScramble) {
            return base.Channel.HostGameAsync(userName, wordToScramble);
        }
        
        public WordScrambleConsoleGame.WordScrambleServiceReference.Word Join(string playerName) {
            return base.Channel.Join(playerName);
        }
        
        public System.Threading.Tasks.Task<WordScrambleConsoleGame.WordScrambleServiceReference.Word> JoinAsync(string playerName) {
            return base.Channel.JoinAsync(playerName);
        }
        
        public bool GuessWord(string playerName, string guessedWord, string unscrambledWord) {
            return base.Channel.GuessWord(playerName, guessedWord, unscrambledWord);
        }
        
        public System.Threading.Tasks.Task<bool> GuessWordAsync(string playerName, string guessedWord, string unscrambledWord) {
            return base.Channel.GuessWordAsync(playerName, guessedWord, unscrambledWord);
        }
        
        public void LogOut(string playerName) {
            base.Channel.LogOut(playerName);
        }
        
        public System.Threading.Tasks.Task LogOutAsync(string playerName) {
            return base.Channel.LogOutAsync(playerName);
        }
        
        public void EndGame(string playerName) {
            base.Channel.EndGame(playerName);
        }
        
        public System.Threading.Tasks.Task EndGameAsync(string playerName) {
            return base.Channel.EndGameAsync(playerName);
        }
    }
}
