/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Skills;
using Opc.Ua.Di;

namespace Example.LinearAxisWithGripper
{
    #region GripStartMethodState Class
    #if (!OPCUA_EXCLUDE_GripStartMethodState)
    /// <summary>
    /// Stores an instance of the GripStartMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GripStartMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GripStartMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new GripStartMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8jAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1NraWxscy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIKBAAAAAEAEwAAAEdyaXBTdGFydE1ldGhvZFR5cGUBAbo6AC8B" +
           "Abo6ujoAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQG7OgAuAES7OgAAlgIA" +
           "AAABACoBARMAAAAEAAAAU3BhbgAL/////wAAAAAAAQAqAQEUAAAABQAAAEZvcmNlAAv/////AAAAAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public GripStartMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            double span = (double)_inputArguments[0];
            double force = (double)_inputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    span,
                    force);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult GripStartMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        double span,
        double force);
    #endif
    #endregion

    #region GraspSkillState Class
    #if (!OPCUA_EXCLUDE_GraspSkillState)
    /// <summary>
    /// Stores an instance of the GraspSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GraspSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GraspSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Example.LinearAxisWithGripper.ObjectTypes.GraspSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8jAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1NraWxscy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////+EYIACAQAAAAEAFgAAAEdyYXNwU2tpbGxUeXBlSW5zdGFuY2UBAbw6" +
           "AQG8Orw6AAAB/////wMAAAAVYKkKAgAAAAIACgAAAElkZW50aWZpZXIBAb06AC4ARL06AAAMCgAAAEdy" +
           "YXNwU2tpbGwADP////8BAf////8AAAAAFWCpCgIAAAACAA4AAABJc0luc3RhbnRpYWJsZQEBvjoALgBE" +
           "vjoAAAEAAAH/////AQH/////AAAAAARggAoBAAAAAgAMAAAAU3RhdGVNYWNoaW5lAQHAOgAvAQLaOsA6" +
           "AAD/////FAAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQHBOgAvAQDICsE6AAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBwjoALgBEwjoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAA" +
           "DgAAAExhc3RUcmFuc2l0aW9uAQHGOgAvAQDKCsY6AAAAFf////8BAf////8CAAAAFWCJCgIAAAAAAAIA" +
           "AABJZAEBxzoALgBExzoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAADgAAAFRyYW5zaXRpb25UaW1l" +
           "AQHKOgAuAETKOgAAAQAmAf////8BAf////8AAAAABGGCCgQAAAACAAUAAABTdGFydAEBzjoALwEC6DrO" +
           "OgAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAc86AC4ARM86AACWAgAAAAEA" +
           "KgEBEwAAAAQAAABTcGFuAAv/////AAAAAAABACoBARQAAAAFAAAARm9yY2UAC/////8AAAAAAAEAKAEB" +
           "AAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAACAAQAAABIYWx0AQHROgAvAQLrOtE6AAABAf////8A" +
           "AAAABGGCCgQAAAACAAUAAABSZXNldAEB1DoALwEC7jrUOgAAAQH/////AAAAAARhggoEAAAAAgAGAAAA" +
           "UmVzdW1lAQHXOgAvAQLxOtc6AAABAf////8AAAAABGGCCgQAAAACAAcAAABTdXNwZW5kAQHaOgAvAQL0" +
           "Oto6AAABAf////8AAAAABGCACgEAAAACAAcAAABSdW5uaW5nAQHdOgAvAQK7Ot06AAAFAAAAADQBAQHz" +
           "OgAzAQEB9ToAMwEBAfc6ADMBAQH5OgA0AQEB+zoCAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB" +
           "3joALgBE3joAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIAEwAAAENvbnRpbnVvdXNQYXJhbWV0ZXIB" +
           "Ad86AC8AOt86AAD/////AQAAAARggAoBAAAAAgAPAAAAT3V0cHV0UGFyYW1ldGVyAQHhOgAvADrhOgAA" +
           "/////wEAAAA1YIkKAgAAAAEADAAAAEN1cnJlbnRGb3JjZQEBAzsDAAAAACsAAABDdXJyZW50IGZvcmNl" +
           "IGFjdGluZyBvbiB0aGUgZ3JpcHBlciBmaW5nZXJzAC8APwM7AAAAC/////8BAf////8AAAAABGCACgEA" +
           "AAACAAUAAABSZWFkeQEB4joALwECuzriOgAABQAAAAA0AQEB8ToAMwEBAfM6ADQBAQH3OgA0AQEB/zoA" +
           "MwEBAQE7AQAAABVgiQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAeM6AC4AROM6AAAAB/////8BAf////8A" +
           "AAAABGCACgEAAAACAAYAAABIYWx0ZWQBAec6AC8BArs65zoAAAQAAAAAMwEBAfE6ADQBAQH1OgA0AQEB" +
           "/ToANAEBAQE7AQAAABVgiQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAeg6AC4AROg6AAAAB/////8BAf//" +
           "//8AAAAABGCACgEAAAACAAkAAABTdXNwZW5kZWQBAew6AC8BArs67DoAAAQAAAAANAEBAfk6ADMBAQH7" +
           "OgAzAQEB/ToAMwEBAf86AQAAABVgiQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAe06AC4ARO06AAAAB///" +
           "//8BAf////8AAAAABGCACgEAAAACAA0AAABIYWx0ZWRUb1JlYWR5AQHxOgAvAQAGCfE6AAADAAAAADMA" +
           "AQHnOgA0AAEB4joANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB8joALgBE" +
           "8joAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIADgAAAFJlYWR5VG9SdW5uaW5nAQHzOgAvAQAGCfM6" +
           "AAADAAAAADMAAQHiOgA0AAEB3ToANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJl" +
           "cgEB9DoALgBE9DoAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIADwAAAFJ1bm5pbmdUb0hhbHRlZAEB" +
           "9ToALwEABgn1OgAAAwAAAAAzAAEB3ToANAABAec6ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5z" +
           "aXRpb25OdW1iZXIBAfY6AC4ARPY6AAAAB/////8BAf////8AAAAABGCACgEAAAACAA4AAABSdW5uaW5n" +
           "VG9SZWFkeQEB9zoALwEABgn3OgAAAwAAAAAzAAEB3ToANAABAeI6ADYAAQLAOgEAAAAVYIkKAgAAAAAA" +
           "EAAAAFRyYW5zaXRpb25OdW1iZXIBAfg6AC4ARPg6AAAAB/////8BAf////8AAAAABGCACgEAAAACABIA" +
           "AABSdW5uaW5nVG9TdXNwZW5kZWQBAfk6AC8BAAYJ+ToAAAMAAAAAMwABAd06ADQAAQHsOgA2AAECwDoB" +
           "AAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQH6OgAuAET6OgAAAAf/////AQH/////AAAA" +
           "AARggAoBAAAAAgASAAAAU3VzcGVuZGVkVG9SdW5uaW5nAQH7OgAvAQAGCfs6AAADAAAAADMAAQHsOgA0" +
           "AAEB3ToANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB/DoALgBE/DoAAAAH" +
           "/////wEB/////wAAAAAEYIAKAQAAAAIAEQAAAFN1c3BlbmRlZFRvSGFsdGVkAQH9OgAvAQAGCf06AAAD" +
           "AAAAADMAAQHsOgA0AAEB5zoANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB" +
           "/joALgBE/joAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIAEAAAAFN1c3BlbmRlZFRvUmVhZHkBAf86" +
           "AC8BAAYJ/zoAAAMAAAAAMwABAew6ADQAAQHiOgA2AAECwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0" +
           "aW9uTnVtYmVyAQEAOwAuAEQAOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgANAAAAUmVhZHlUb0hh" +
           "bHRlZAEBATsALwEABgkBOwAAAwAAAAAzAAEB4joANAABAec6ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAA" +
           "AFRyYW5zaXRpb25OdW1iZXIBAQI7AC4ARAI7AAAAB/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ReleaseStartMethodState Class
    #if (!OPCUA_EXCLUDE_ReleaseStartMethodState)
    /// <summary>
    /// Stores an instance of the ReleaseStartMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReleaseStartMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ReleaseStartMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new ReleaseStartMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8jAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1NraWxscy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIKBAAAAAEAFgAAAFJlbGVhc2VTdGFydE1ldGhvZFR5cGUBAQQ7" +
           "AC8BAQQ7BDsAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEFOwAuAEQFOwAA" +
           "lgEAAAABACoBARMAAAAEAAAAU3BhbgAL/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public ReleaseStartMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            double span = (double)_inputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    span);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult ReleaseStartMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        double span);
    #endif
    #endregion

    #region ReleaseSkillState Class
    #if (!OPCUA_EXCLUDE_ReleaseSkillState)
    /// <summary>
    /// Stores an instance of the ReleaseSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReleaseSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ReleaseSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Example.LinearAxisWithGripper.ObjectTypes.ReleaseSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8jAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1NraWxscy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////+EYIACAQAAAAEAGAAAAFJlbGVhc2VTa2lsbFR5cGVJbnN0YW5jZQEB" +
           "BjsBAQY7BjsAAAH/////AwAAABVgqQoCAAAAAgAKAAAASWRlbnRpZmllcgEBBzsALgBEBzsAAAwMAAAA" +
           "UmVsZWFzZVNraWxsAAz/////AQH/////AAAAABVgqQoCAAAAAgAOAAAASXNJbnN0YW50aWFibGUBAQg7" +
           "AC4ARAg7AAABAAAB/////wEB/////wAAAAAEYIAKAQAAAAIADAAAAFN0YXRlTWFjaGluZQEBCjsALwEC" +
           "2joKOwAA/////xQAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBCzsALwEAyAoLOwAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQw7AC4ARAw7AAAAEf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAA4AAABMYXN0VHJhbnNpdGlvbgEBEDsALwEAygoQOwAAABX/////AQH/////AgAAABVgiQoCAAAA" +
           "AAACAAAASWQBARE7AC4ARBE7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAA4AAABUcmFuc2l0aW9u" +
           "VGltZQEBFDsALgBEFDsAAAEAJgH/////AQH/////AAAAAARhggoEAAAAAgAFAAAAU3RhcnQBARg7AC8B" +
           "Aug6GDsAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEZOwAuAEQZOwAAlgEA" +
           "AAABACoBARMAAAAEAAAAU3BhbgAL/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAIABAAAAEhhbHQBARs7AC8BAus6GzsAAAEB/////wAAAAAEYYIKBAAAAAIABQAAAFJlc2V0AQEe" +
           "OwAvAQLuOh47AAABAf////8AAAAABGGCCgQAAAACAAYAAABSZXN1bWUBASE7AC8BAvE6ITsAAAEB////" +
           "/wAAAAAEYYIKBAAAAAIABwAAAFN1c3BlbmQBASQ7AC8BAvQ6JDsAAAEB/////wAAAAAEYIAKAQAAAAIA" +
           "BwAAAFJ1bm5pbmcBASc7AC8BArs6JzsAAAUAAAAANAEBAT07ADMBAQE/OwAzAQEBQTsAMwEBAUM7ADQB" +
           "AQFFOwEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQEoOwAuAEQoOwAAAAf/////AQH/////AAAA" +
           "AARggAoBAAAAAgAFAAAAUmVhZHkBASw7AC8BArs6LDsAAAUAAAAANAEBATs7ADMBAQE9OwA0AQEBQTsA" +
           "NAEBAUk7ADMBAQFLOwEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQEtOwAuAEQtOwAAAAf/////" +
           "AQH/////AAAAAARggAoBAAAAAgAGAAAASGFsdGVkAQExOwAvAQK7OjE7AAAEAAAAADMBAQE7OwA0AQEB" +
           "PzsANAEBAUc7ADQBAQFLOwEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQEyOwAuAEQyOwAAAAf/" +
           "////AQH/////AAAAAARggAoBAAAAAgAJAAAAU3VzcGVuZGVkAQE2OwAvAQK7OjY7AAAEAAAAADQBAQFD" +
           "OwAzAQEBRTsAMwEBAUc7ADMBAQFJOwEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQE3OwAuAEQ3" +
           "OwAAAAf/////AQH/////AAAAAARggAoBAAAAAgANAAAASGFsdGVkVG9SZWFkeQEBOzsALwEABgk7OwAA" +
           "AwAAAAAzAAEBMTsANAABASw7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIB" +
           "ATw7AC4ARDw7AAAAB/////8BAf////8AAAAABGCACgEAAAACAA4AAABSZWFkeVRvUnVubmluZwEBPTsA" +
           "LwEABgk9OwAAAwAAAAAzAAEBLDsANAABASc7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRp" +
           "b25OdW1iZXIBAT47AC4ARD47AAAAB/////8BAf////8AAAAABGCACgEAAAACAA8AAABSdW5uaW5nVG9I" +
           "YWx0ZWQBAT87AC8BAAYJPzsAAAMAAAAAMwABASc7ADQAAQExOwA2AAECwDoBAAAAFWCJCgIAAAAAABAA" +
           "AABUcmFuc2l0aW9uTnVtYmVyAQFAOwAuAERAOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgAOAAAA" +
           "UnVubmluZ1RvUmVhZHkBAUE7AC8BAAYJQTsAAAMAAAAAMwABASc7ADQAAQEsOwA2AAECwDoBAAAAFWCJ" +
           "CgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFCOwAuAERCOwAAAAf/////AQH/////AAAAAARggAoB" +
           "AAAAAgASAAAAUnVubmluZ1RvU3VzcGVuZGVkAQFDOwAvAQAGCUM7AAADAAAAADMAAQEnOwA0AAEBNjsA" +
           "NgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBRDsALgBERDsAAAAH/////wEB" +
           "/////wAAAAAEYIAKAQAAAAIAEgAAAFN1c3BlbmRlZFRvUnVubmluZwEBRTsALwEABglFOwAAAwAAAAAz" +
           "AAEBNjsANAABASc7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAUY7AC4A" +
           "REY7AAAAB/////8BAf////8AAAAABGCACgEAAAACABEAAABTdXNwZW5kZWRUb0hhbHRlZAEBRzsALwEA" +
           "BglHOwAAAwAAAAAzAAEBNjsANAABATE7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
           "dW1iZXIBAUg7AC4AREg7AAAAB/////8BAf////8AAAAABGCACgEAAAACABAAAABTdXNwZW5kZWRUb1Jl" +
           "YWR5AQFJOwAvAQAGCUk7AAADAAAAADMAAQE2OwA0AAEBLDsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAA" +
           "VHJhbnNpdGlvbk51bWJlcgEBSjsALgBESjsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIADQAAAFJl" +
           "YWR5VG9IYWx0ZWQBAUs7AC8BAAYJSzsAAAMAAAAAMwABASw7ADQAAQExOwA2AAECwDoBAAAAFWCJCgIA" +
           "AAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFMOwAuAERMOwAAAAf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MoveToAbsStartMethodState Class
    #if (!OPCUA_EXCLUDE_MoveToAbsStartMethodState)
    /// <summary>
    /// Stores an instance of the MoveToAbsStartMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MoveToAbsStartMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MoveToAbsStartMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new MoveToAbsStartMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8jAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1NraWxscy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIKBAAAAAEAGAAAAE1vdmVUb0Fic1N0YXJ0TWV0aG9kVHlwZQEB" +
           "TTsALwEBTTtNOwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAU47AC4ARE47" +
           "AACWAQAAAAEAKgEBFwAAAAgAAABQb3NpdGlvbgAL/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public MoveToAbsStartMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            double position = (double)_inputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    position);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult MoveToAbsStartMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        double position);
    #endif
    #endregion

    #region MoveToAbsPosSkillState Class
    #if (!OPCUA_EXCLUDE_MoveToAbsPosSkillState)
    /// <summary>
    /// Stores an instance of the MoveToAbsPosSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MoveToAbsPosSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MoveToAbsPosSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Example.LinearAxisWithGripper.ObjectTypes.MoveToAbsPosSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8jAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1NraWxscy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////+EYIACAQAAAAEAHQAAAE1vdmVUb0Fic1Bvc1NraWxsVHlwZUluc3Rh" +
           "bmNlAQFPOwEBTztPOwAAAf////8DAAAAFWCpCgIAAAACAAoAAABJZGVudGlmaWVyAQFQOwAuAERQOwAA" +
           "DBEAAABNb3ZlVG9BYnNQb3NTa2lsbAAM/////wEB/////wAAAAAVYKkKAgAAAAIADgAAAElzSW5zdGFu" +
           "dGlhYmxlAQFROwAuAERROwAAAQAAAf////8BAf////8AAAAABGCACgEAAAACAAwAAABTdGF0ZU1hY2hp" +
           "bmUBAVM7AC8BAto6UzsAAP////8UAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAVQ7AC8BAMgK" +
           "VDsAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFVOwAuAERVOwAAABH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAAOAAAATGFzdFRyYW5zaXRpb24BAVk7AC8BAMoKWTsAAAAV/////wEB/////wIA" +
           "AAAVYIkKAgAAAAAAAgAAAElkAQFaOwAuAERaOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAOAAAA" +
           "VHJhbnNpdGlvblRpbWUBAV07AC4ARF07AAABACYB/////wEB/////wAAAAAEYYIKBAAAAAIABQAAAFN0" +
           "YXJ0AQFhOwAvAQLoOmE7AAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBYjsA" +
           "LgBEYjsAAJYBAAAAAQAqAQEXAAAACAAAAFBvc2l0aW9uAAv/////AAAAAAABACgBAQAAAAEAAAAAAAAA" +
           "AQH/////AAAAAARhggoEAAAAAgAEAAAASGFsdAEBZDsALwEC6zpkOwAAAQH/////AAAAAARhggoEAAAA" +
           "AgAFAAAAUmVzZXQBAWc7AC8BAu46ZzsAAAEB/////wAAAAAEYYIKBAAAAAIABgAAAFJlc3VtZQEBajsA" +
           "LwEC8TpqOwAAAQH/////AAAAAARhggoEAAAAAgAHAAAAU3VzcGVuZAEBbTsALwEC9DptOwAAAQH/////" +
           "AAAAAARggAoBAAAAAgAHAAAAUnVubmluZwEBcDsALwECuzpwOwAABQAAAAA0AQEBhjsAMwEBAYg7ADMB" +
           "AQGKOwAzAQEBjDsANAEBAY47AgAAABVgiQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAXE7AC4ARHE7AAAA" +
           "B/////8BAf////8AAAAABGCACgEAAAACABMAAABDb250aW51b3VzUGFyYW1ldGVyAQFyOwAvADpyOwAA" +
           "/////wEAAAAEYIAKAQAAAAIADwAAAE91dHB1dFBhcmFtZXRlcgEBdDsALwA6dDsAAP////8BAAAANWCJ" +
           "CgIAAAABAA8AAABDdXJyZW50UG9zaXRpb24BAZY7AwAAAAAjAAAAQ3VycmVudCBwb3NpdGlvbiBvZiB0" +
           "aGUgbGluZWFyIGF4aXMALwA/ljsAAAAL/////wEB/////wAAAAAEYIAKAQAAAAIABQAAAFJlYWR5AQF1" +
           "OwAvAQK7OnU7AAAFAAAAADQBAQGEOwAzAQEBhjsANAEBAYo7ADQBAQGSOwAzAQEBlDsBAAAAFWCJCgIA" +
           "AAAAAAsAAABTdGF0ZU51bWJlcgEBdjsALgBEdjsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIABgAA" +
           "AEhhbHRlZAEBejsALwECuzp6OwAABAAAAAAzAQEBhDsANAEBAYg7ADQBAQGQOwA0AQEBlDsBAAAAFWCJ" +
           "CgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBezsALgBEezsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIA" +
           "CQAAAFN1c3BlbmRlZAEBfzsALwECuzp/OwAABAAAAAA0AQEBjDsAMwEBAY47ADMBAQGQOwAzAQEBkjsB" +
           "AAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBgDsALgBEgDsAAAAH/////wEB/////wAAAAAEYIAK" +
           "AQAAAAIADQAAAEhhbHRlZFRvUmVhZHkBAYQ7AC8BAAYJhDsAAAMAAAAAMwABAXo7ADQAAQF1OwA2AAEC" +
           "wDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQGFOwAuAESFOwAAAAf/////AQH/////" +
           "AAAAAARggAoBAAAAAgAOAAAAUmVhZHlUb1J1bm5pbmcBAYY7AC8BAAYJhjsAAAMAAAAAMwABAXU7ADQA" +
           "AQFwOwA2AAECwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQGHOwAuAESHOwAAAAf/" +
           "////AQH/////AAAAAARggAoBAAAAAgAPAAAAUnVubmluZ1RvSGFsdGVkAQGIOwAvAQAGCYg7AAADAAAA" +
           "ADMAAQFwOwA0AAEBejsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBiTsA" +
           "LgBEiTsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIADgAAAFJ1bm5pbmdUb1JlYWR5AQGKOwAvAQAG" +
           "CYo7AAADAAAAADMAAQFwOwA0AAEBdTsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51" +
           "bWJlcgEBizsALgBEizsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIAEgAAAFJ1bm5pbmdUb1N1c3Bl" +
           "bmRlZAEBjDsALwEABgmMOwAAAwAAAAAzAAEBcDsANAABAX87ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAA" +
           "AFRyYW5zaXRpb25OdW1iZXIBAY07AC4ARI07AAAAB/////8BAf////8AAAAABGCACgEAAAACABIAAABT" +
           "dXNwZW5kZWRUb1J1bm5pbmcBAY47AC8BAAYJjjsAAAMAAAAAMwABAX87ADQAAQFwOwA2AAECwDoBAAAA" +
           "FWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQGPOwAuAESPOwAAAAf/////AQH/////AAAAAARg" +
           "gAoBAAAAAgARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBAZA7AC8BAAYJkDsAAAMAAAAAMwABAX87ADQAAQF6" +
           "OwA2AAECwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQGROwAuAESROwAAAAf/////" +
           "AQH/////AAAAAARggAoBAAAAAgAQAAAAU3VzcGVuZGVkVG9SZWFkeQEBkjsALwEABgmSOwAAAwAAAAAz" +
           "AAEBfzsANAABAXU7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAZM7AC4A" +
           "RJM7AAAAB/////8BAf////8AAAAABGCACgEAAAACAA0AAABSZWFkeVRvSGFsdGVkAQGUOwAvAQAGCZQ7" +
           "AAADAAAAADMAAQF1OwA0AAEBejsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJl" +
           "cgEBlTsALgBElTsAAAAH/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PickMethodState Class
    #if (!OPCUA_EXCLUDE_PickMethodState)
    /// <summary>
    /// Stores an instance of the PickMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PickMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PickMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new PickMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8jAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1NraWxscy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYYIKBAAAAAEADgAAAFBpY2tNZXRob2RUeXBlAQGXOwAvAQGXO5c7" +
           "AAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBmDsALgBEmDsAAJYCAAAAAQAq" +
           "AQEXAAAACAAAAFBvc2l0aW9uAAv/////AAAAAAABACoBARMAAAAEAAAAU3BhbgAL/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public PickMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            double position = (double)_inputArguments[0];
            double span = (double)_inputArguments[1];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    position,
                    span);
            }

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult PickMethodStateMethodCallHandler(
        ISystemContext context,
        MethodState method,
        NodeId objectId,
        double position,
        double span);
    #endif
    #endregion

    #region PickSkillState Class
    #if (!OPCUA_EXCLUDE_PickSkillState)
    /// <summary>
    /// Stores an instance of the PickSkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PickSkillState : SkillState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PickSkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Example.LinearAxisWithGripper.ObjectTypes.PickSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8jAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1NraWxscy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////+EYIACAQAAAAEAFQAAAFBpY2tTa2lsbFR5cGVJbnN0YW5jZQEBmTsB" +
           "AZk7mTsAAAH/////AwAAABVgqQoCAAAAAgAKAAAASWRlbnRpZmllcgEBmjsALgBEmjsAAAwNAAAAUGlj" +
           "a1NraWxsVHlwZQAM/////wEB/////wAAAAAVYKkKAgAAAAIADgAAAElzSW5zdGFudGlhYmxlAQGbOwAu" +
           "AESbOwAAAQAAAf////8BAf////8AAAAABGCACgEAAAACAAwAAABTdGF0ZU1hY2hpbmUBAZ07AC8BAto6" +
           "nTsAAP////8UAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAZ47AC8BAMgKnjsAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGfOwAuAESfOwAAABH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAOAAAATGFzdFRyYW5zaXRpb24BAaM7AC8BAMoKozsAAAAV/////wEB/////wIAAAAVYIkKAgAAAAAA" +
           "AgAAAElkAQGkOwAuAESkOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAOAAAAVHJhbnNpdGlvblRp" +
           "bWUBAac7AC4ARKc7AAABACYB/////wEB/////wAAAAAEYYIKBAAAAAIABQAAAFN0YXJ0AQGrOwAvAQLo" +
           "Oqs7AAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBrDsALgBErDsAAJYCAAAA" +
           "AQAqAQEXAAAACAAAAFBvc2l0aW9uAAv/////AAAAAAABACoBARMAAAAEAAAAU3BhbgAL/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAIABAAAAEhhbHQBAa47AC8BAus6rjsAAAEB" +
           "/////wAAAAAEYYIKBAAAAAIABQAAAFJlc2V0AQGxOwAvAQLuOrE7AAABAf////8AAAAABGGCCgQAAAAC" +
           "AAYAAABSZXN1bWUBAbQ7AC8BAvE6tDsAAAEB/////wAAAAAEYYIKBAAAAAIABwAAAFN1c3BlbmQBAbc7" +
           "AC8BAvQ6tzsAAAEB/////wAAAAAEYIAKAQAAAAIABwAAAFJ1bm5pbmcBAbo7AC8BArs6ujsAAAUAAAAA" +
           "NAEBAdA7ADMBAQHSOwAzAQEB1DsAMwEBAdY7ADQBAQHYOwEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVt" +
           "YmVyAQG7OwAuAES7OwAAAAf/////AQH/////AAAAAARggAoBAAAAAgAFAAAAUmVhZHkBAb87AC8BArs6" +
           "vzsAAAUAAAAANAEBAc47ADMBAQHQOwA0AQEB1DsANAEBAdw7ADMBAQHeOwEAAAAVYIkKAgAAAAAACwAA" +
           "AFN0YXRlTnVtYmVyAQHAOwAuAETAOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgAGAAAASGFsdGVk" +
           "AQHEOwAvAQK7OsQ7AAAEAAAAADMBAQHOOwA0AQEB0jsANAEBAdo7ADQBAQHeOwEAAAAVYIkKAgAAAAAA" +
           "CwAAAFN0YXRlTnVtYmVyAQHFOwAuAETFOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgAJAAAAU3Vz" +
           "cGVuZGVkAQHJOwAvAQK7Osk7AAAEAAAAADQBAQHWOwAzAQEB2DsAMwEBAdo7ADMBAQHcOwEAAAAVYIkK" +
           "AgAAAAAACwAAAFN0YXRlTnVtYmVyAQHKOwAuAETKOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgAN" +
           "AAAASGFsdGVkVG9SZWFkeQEBzjsALwEABgnOOwAAAwAAAAAzAAEBxDsANAABAb87ADYAAQLAOgEAAAAV" +
           "YIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAc87AC4ARM87AAAAB/////8BAf////8AAAAABGCA" +
           "CgEAAAACAA4AAABSZWFkeVRvUnVubmluZwEB0DsALwEABgnQOwAAAwAAAAAzAAEBvzsANAABAbo7ADYA" +
           "AQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAdE7AC4ARNE7AAAAB/////8BAf//" +
           "//8AAAAABGCACgEAAAACAA8AAABSdW5uaW5nVG9IYWx0ZWQBAdI7AC8BAAYJ0jsAAAMAAAAAMwABAbo7" +
           "ADQAAQHEOwA2AAECwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHTOwAuAETTOwAA" +
           "AAf/////AQH/////AAAAAARggAoBAAAAAgAOAAAAUnVubmluZ1RvUmVhZHkBAdQ7AC8BAAYJ1DsAAAMA" +
           "AAAAMwABAbo7ADQAAQG/OwA2AAECwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHV" +
           "OwAuAETVOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgASAAAAUnVubmluZ1RvU3VzcGVuZGVkAQHW" +
           "OwAvAQAGCdY7AAADAAAAADMAAQG6OwA0AAEByTsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNp" +
           "dGlvbk51bWJlcgEB1zsALgBE1zsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIAEgAAAFN1c3BlbmRl" +
           "ZFRvUnVubmluZwEB2DsALwEABgnYOwAAAwAAAAAzAAEByTsANAABAbo7ADYAAQLAOgEAAAAVYIkKAgAA" +
           "AAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAdk7AC4ARNk7AAAAB/////8BAf////8AAAAABGCACgEAAAAC" +
           "ABEAAABTdXNwZW5kZWRUb0hhbHRlZAEB2jsALwEABgnaOwAAAwAAAAAzAAEByTsANAABAcQ7ADYAAQLA" +
           "OgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAds7AC4ARNs7AAAAB/////8BAf////8A" +
           "AAAABGCACgEAAAACABAAAABTdXNwZW5kZWRUb1JlYWR5AQHcOwAvAQAGCdw7AAADAAAAADMAAQHJOwA0" +
           "AAEBvzsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB3TsALgBE3TsAAAAH" +
           "/////wEB/////wAAAAAEYIAKAQAAAAIADQAAAFJlYWR5VG9IYWx0ZWQBAd47AC8BAAYJ3jsAAAMAAAAA" +
           "MwABAb87ADQAAQHEOwA2AAECwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHfOwAu" +
           "AETfOwAAAAf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LinAxisWithGripperState Class
    #if (!OPCUA_EXCLUDE_LinAxisWithGripperState)
    /// <summary>
    /// Stores an instance of the LinAxisWithGripperType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LinAxisWithGripperState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LinAxisWithGripperState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Example.LinearAxisWithGripper.ObjectTypes.LinAxisWithGripperType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AwAAADYAAABodHRwczovL2V4YW1wbGUuY29tL1VBL0V4YW1wbGVzL0xpbmVhckF4aXNXaXRoR3JpcHBl" +
           "ci8jAAAAaHR0cDovL29wY2ZvdW5kYXRpb24ub3JnL1VBL1NraWxscy8fAAAAaHR0cDovL29wY2ZvdW5k" +
           "YXRpb24ub3JnL1VBL0RJL/////8EYIACAQAAAAEAHgAAAExpbkF4aXNXaXRoR3JpcHBlclR5cGVJbnN0" +
           "YW5jZQEB4DsBAeA74DsAAP////8IAAAANWCJCgIAAAADAAwAAABNYW51ZmFjdHVyZXIBAfc7AwAAAAAw" +
           "AAAATmFtZSBvZiB0aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARPc7AAAA" +
           "Ff////8BAf////8AAAAANWCJCgIAAAADAAUAAABNb2RlbAEB+TsDAAAAABgAAABNb2RlbCBuYW1lIG9m" +
           "IHRoZSBkZXZpY2UALgBE+TsAAAAV/////wEB/////wAAAAA1YIkKAgAAAAMAEAAAAEhhcmR3YXJlUmV2" +
           "aXNpb24BAfo7AwAAAAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZp" +
           "Y2UALgBE+jsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAMAEAAAAFNvZnR3YXJlUmV2aXNpb24BAfs7" +
           "AwAAAAA1AAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZp" +
           "Y2UALgBE+zsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAMADgAAAERldmljZVJldmlzaW9uAQH8OwMA" +
           "AAAAJAAAAE92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAET8OwAAAAz/////AQH/" +
           "////AAAAADVgiQoCAAAAAwAMAAAARGV2aWNlTWFudWFsAQH+OwMAAAAAWgAAAEFkZHJlc3MgKHBhdGhu" +
           "YW1lIGluIHRoZSBmaWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVh" +
           "bCBmb3IgdGhlIGRldmljZQAuAET+OwAAAAz/////AQH/////AAAAADVgiQoCAAAAAwAMAAAAU2VyaWFs" +
           "TnVtYmVyAQEAPAMAAAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRo" +
           "aW4gYSBtYW51ZmFjdHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARAA8AAAADP////8BAf////8AAAAA" +
           "NWCJCgIAAAADAA8AAABSZXZpc2lvbkNvdW50ZXIBAQI8AwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291" +
           "bnRlciBpbmRpY2F0aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0" +
           "aGUgRGV2aWNlIGhhcyBiZWVuIG1vZGlmaWVkAC4ARAI8AAAABv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}