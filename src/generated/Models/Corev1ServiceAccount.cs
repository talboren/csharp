// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ServiceAccount binds together: * a name, understood by users, and
    /// perhaps by peripheral systems, for an identity * a principal that can
    /// be authenticated and authorized * a set of secrets
    /// </summary>
    public partial class Corev1ServiceAccount
    {
        /// <summary>
        /// Initializes a new instance of the Corev1ServiceAccount class.
        /// </summary>
        public Corev1ServiceAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1ServiceAccount class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</param>
        /// <param
        /// name="automountServiceAccountToken">AutomountServiceAccountToken
        /// indicates whether pods running as this service account should have
        /// an API token automatically mounted. Can be overridden at the pod
        /// level.</param>
        /// <param name="imagePullSecrets">ImagePullSecrets is a list of
        /// references to secrets in the same namespace to use for pulling any
        /// images in pods that reference this ServiceAccount. ImagePullSecrets
        /// are distinct from Secrets because Secrets can be mounted in the
        /// pod, but ImagePullSecrets are only accessed by the kubelet. More
        /// info:
        /// https://kubernetes.io/docs/concepts/containers/images/#specifying-imagepullsecrets-on-a-pod</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</param>
        /// <param name="secrets">Secrets is the list of secrets allowed to be
        /// used by pods running using this ServiceAccount. More info:
        /// https://kubernetes.io/docs/concepts/configuration/secret</param>
        public Corev1ServiceAccount(string apiVersion = default(string), bool? automountServiceAccountToken = default(bool?), IList<Corev1LocalObjectReference> imagePullSecrets = default(IList<Corev1LocalObjectReference>), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta), IList<Corev1ObjectReference> secrets = default(IList<Corev1ObjectReference>))
        {
            ApiVersion = apiVersion;
            AutomountServiceAccountToken = automountServiceAccountToken;
            ImagePullSecrets = imagePullSecrets;
            Kind = kind;
            Metadata = metadata;
            Secrets = secrets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets automountServiceAccountToken indicates whether pods
        /// running as this service account should have an API token
        /// automatically mounted. Can be overridden at the pod level.
        /// </summary>
        [JsonProperty(PropertyName = "automountServiceAccountToken")]
        public bool? AutomountServiceAccountToken { get; set; }

        /// <summary>
        /// Gets or sets imagePullSecrets is a list of references to secrets in
        /// the same namespace to use for pulling any images in pods that
        /// reference this ServiceAccount. ImagePullSecrets are distinct from
        /// Secrets because Secrets can be mounted in the pod, but
        /// ImagePullSecrets are only accessed by the kubelet. More info:
        /// https://kubernetes.io/docs/concepts/containers/images/#specifying-imagepullsecrets-on-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "imagePullSecrets")]
        public IList<Corev1LocalObjectReference> ImagePullSecrets { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets secrets is the list of secrets allowed to be used by
        /// pods running using this ServiceAccount. More info:
        /// https://kubernetes.io/docs/concepts/configuration/secret
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<Corev1ObjectReference> Secrets { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Metadata != null)
            {
                Metadata.Validate();
            }
        }
    }
}