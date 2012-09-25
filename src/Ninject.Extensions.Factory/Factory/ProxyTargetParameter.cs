//-------------------------------------------------------------------------------
// <copyright file="ProxyTargetParameter.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2011 Ninject Project Contributors
//   Authors: Remo Gloor (remo.gloor@gmail.com)
//           
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   you may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

#if !SILVERLIGHT_20 && !WINDOWS_PHONE && !NETCF_35
namespace Ninject.Extensions.Factory
{
    using Ninject.Activation;
    using Ninject.Parameters;
    using Ninject.Planning.Targets;

    /// <summary>
    /// Used to define that the target parameter of the factory interception is <c>null</c>.
    /// </summary>
    public class ProxyTargetParameter : Parameter, IConstructorArgument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyTargetParameter"/> class.
        /// </summary>
        public ProxyTargetParameter()
            : base("ProxyTargetParameter", (object)null, false)
        {
        }

        /// <summary>
        /// Determines if the parameter applies to the given target.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="target">The target.</param>
        /// <returns>
        /// True if the parameter applies in the specified context to the specified target.
        /// </returns>
        /// <remarks>
        /// Only one parameter may return <c>true</c>.
        /// </remarks>
        public bool AppliesToTarget(IContext context, ITarget target)
        {
            return target.Type == typeof(object);
        }
    }
}
#endif