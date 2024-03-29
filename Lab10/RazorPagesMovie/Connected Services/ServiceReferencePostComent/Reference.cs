﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferencePostComent
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/Lab6")]
    public partial class Post : object
    {
        
        private System.Collections.Generic.List<ServiceReferencePostComent.Comment> CommentsField;
        
        private System.DateTime DateField;
        
        private string DescriptionField;
        
        private string DomainField;
        
        private int PostIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferencePostComent.Comment> Comments
        {
            get
            {
                return this.CommentsField;
            }
            set
            {
                this.CommentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Domain
        {
            get
            {
                return this.DomainField;
            }
            set
            {
                this.DomainField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PostId
        {
            get
            {
                return this.PostIdField;
            }
            set
            {
                this.PostIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/Lab6", IsReference=true)]
    public partial class Comment : object
    {
        
        private int CommentIdField;
        
        private ServiceReferencePostComent.Post PostField;
        
        private int PostPostIdField;
        
        private string TextField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CommentId
        {
            get
            {
                return this.CommentIdField;
            }
            set
            {
                this.CommentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferencePostComent.Post Post
        {
            get
            {
                return this.PostField;
            }
            set
            {
                this.PostField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PostPostId
        {
            get
            {
                return this.PostPostIdField;
            }
            set
            {
                this.PostPostIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePostComent.IPostComment")]
    public interface IPostComment
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/AddPost", ReplyAction="http://tempuri.org/InterfacePost/AddPostResponse")]
        System.Threading.Tasks.Task<bool> AddPostAsync(ServiceReferencePostComent.Post post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/UpdatePost", ReplyAction="http://tempuri.org/InterfacePost/UpdatePostResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComent.Post> UpdatePostAsync(ServiceReferencePostComent.Post post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/DeletePost", ReplyAction="http://tempuri.org/InterfacePost/DeletePostResponse")]
        System.Threading.Tasks.Task<int> DeletePostAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPostById", ReplyAction="http://tempuri.org/InterfacePost/GetPostByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComent.Post> GetPostByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPosts", ReplyAction="http://tempuri.org/InterfacePost/GetPostsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePostComent.Post>> GetPostsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/AddComment", ReplyAction="http://tempuri.org/InterfaceComment/AddCommentResponse")]
        System.Threading.Tasks.Task<bool> AddCommentAsync(ServiceReferencePostComent.Comment comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/UpdateComment", ReplyAction="http://tempuri.org/InterfaceComment/UpdateCommentResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComent.Comment> UpdateCommentAsync(ServiceReferencePostComent.Comment newComment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/GetCommentById", ReplyAction="http://tempuri.org/InterfaceComment/GetCommentByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComent.Comment> GetCommentByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IPostCommentChannel : ServiceReferencePostComent.IPostComment, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class PostCommentClient : System.ServiceModel.ClientBase<ServiceReferencePostComent.IPostComment>, ServiceReferencePostComent.IPostComment
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PostCommentClient() : 
                base(PostCommentClient.GetDefaultBinding(), PostCommentClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPostComment.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCommentClient(EndpointConfiguration endpointConfiguration) : 
                base(PostCommentClient.GetBindingForEndpoint(endpointConfiguration), PostCommentClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCommentClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PostCommentClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCommentClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PostCommentClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCommentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> AddPostAsync(ServiceReferencePostComent.Post post)
        {
            return base.Channel.AddPostAsync(post);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComent.Post> UpdatePostAsync(ServiceReferencePostComent.Post post)
        {
            return base.Channel.UpdatePostAsync(post);
        }
        
        public System.Threading.Tasks.Task<int> DeletePostAsync(int id)
        {
            return base.Channel.DeletePostAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComent.Post> GetPostByIdAsync(int id)
        {
            return base.Channel.GetPostByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferencePostComent.Post>> GetPostsAsync()
        {
            return base.Channel.GetPostsAsync();
        }
        
        public System.Threading.Tasks.Task<bool> AddCommentAsync(ServiceReferencePostComent.Comment comment)
        {
            return base.Channel.AddCommentAsync(comment);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComent.Comment> UpdateCommentAsync(ServiceReferencePostComent.Comment newComment)
        {
            return base.Channel.UpdateCommentAsync(newComment);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComent.Comment> GetCommentByIdAsync(int id)
        {
            return base.Channel.GetCommentByIdAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPostComment))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPostComment))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PostCommentClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPostComment);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PostCommentClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPostComment);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPostComment,
        }
    }
}
