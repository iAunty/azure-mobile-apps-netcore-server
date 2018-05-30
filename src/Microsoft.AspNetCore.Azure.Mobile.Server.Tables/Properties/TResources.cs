﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Azure.Mobile.Server.Tables.Properties
{
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TResources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TResources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Mobile.Server.Properties.TResources", typeof(TResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; domain manager does not support soft delete..
        /// </summary>
        internal static string DomainManager_DoesNotSupportSoftDelete
        {
            get
            {
                return ResourceManager.GetString("DomainManager_DoesNotSupportSoftDelete", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; domain manager only supports &apos;{1}&apos; for looking up data. Please use the &apos;{2}&apos; method instead&apos;..
        /// </summary>
        internal static string DomainManager_NoQueryableLookup
        {
            get
            {
                return ResourceManager.GetString("DomainManager_NoQueryableLookup", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; domain manager only supports &apos;{1}&apos; for querying data. Please use the &apos;{2}&apos; method instead&apos;..
        /// </summary>
        internal static string DomainManager_NoQueryableQuery
        {
            get
            {
                return ResourceManager.GetString("DomainManager_NoQueryableQuery", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; domain manager does not support &apos;{1}&apos; for looking up data. Please use the &apos;{2}&apos; method instead&apos;..
        /// </summary>
        internal static string DomainManager_QueryableOnlyLookup
        {
            get
            {
                return ResourceManager.GetString("DomainManager_QueryableOnlyLookup", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; domain manager does not support &apos;{1}&apos; for querying data. Please use the &apos;{2}&apos; method instead&apos;..
        /// </summary>
        internal static string DomainManager_QueryableOnlyQuery
        {
            get
            {
                return ResourceManager.GetString("DomainManager_QueryableOnlyQuery", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter cannot be null..
        /// </summary>
        internal static string ParameterNull
        {
            get
            {
                return ResourceManager.GetString("ParameterNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not set &apos;{0}&apos; value &apos;{1}&apos;..
        /// </summary>
        internal static string TableController_CouldNotSetVersion
        {
            get
            {
                return ResourceManager.GetString("TableController_CouldNotSetVersion", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The HTTP If-Match header is invalid: &apos;{0}&apos;. Updating an existing resource requires a single, strong ETag, or a wildcard ETag..
        /// </summary>
        internal static string TableController_InvalidIfMatch
        {
            get
            {
                return ResourceManager.GetString("TableController_InvalidIfMatch", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; property has not been initialized. Please initialize the property with a &apos;{1}&apos; instance..
        /// </summary>
        internal static string TableController_NoDomainManager
        {
            get
            {
                return ResourceManager.GetString("TableController_NoDomainManager", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not determine the properties for type &apos;{0}&apos;. Inspection failed with error: &apos;{1}&apos;. .
        /// </summary>
        internal static string TableController_NoProperties
        {
            get
            {
                return ResourceManager.GetString("TableController_NoProperties", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The HTTP request did not include a valid entity body. Please ensure there is an entity body and an associated Content-Type header present in the request..
        /// </summary>
        internal static string TableController_NullRequestBody
        {
            get
            {
                return ResourceManager.GetString("TableController_NullRequestBody", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The key &apos;{0}&apos; is invalid. It must follow the pattern &apos;k1&apos;,&apos;k2&apos;,&apos;k3&apos;,....
        /// </summary>
        internal static string TableKeys_InvalidKey
        {
            get
            {
                return ResourceManager.GetString("TableKeys_InvalidKey", resourceCulture);
            }
        }
    }
}
