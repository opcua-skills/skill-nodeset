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
           "AAD/////DwAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQHBOgAvAQDICsE6AAAAFf////8BAf//" +
           "//8BAAAAFWCJCgIAAAAAAAIAAABJZAEBwjoALgBEwjoAAAAR/////wEB/////wAAAAAEYYIKBAAAAAIA" +
           "BQAAAFN0YXJ0AQHOOgAvAQLoOs46AAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBzzoALgBEzzoAAJYCAAAAAQAqAQETAAAABAAAAFNwYW4AC/////8AAAAAAAEAKgEBFAAAAAUAAABG" +
           "b3JjZQAL/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYIAKAQAAAAIABwAAAFJ1bm5p" +
           "bmcBAd06AC8BArs63ToAAAUAAAAANAEBAfM6ADMBAQH1OgAzAQEB9zoAMwEBAfk6ADQBAQH7OgIAAAAV" +
           "YIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQHeOgAuAETeOgAAAAf/////AQH/////AAAAAARggAoBAAAA" +
           "AgATAAAAQ29udGludW91c1BhcmFtZXRlcgEB3zoALwA63zoAAP////8BAAAABGCACgEAAAACAA8AAABP" +
           "dXRwdXRQYXJhbWV0ZXIBAeE6AC8AOuE6AAD/////AQAAADVgiQoCAAAAAQAMAAAAQ3VycmVudEZvcmNl" +
           "AQEDOwMAAAAAKwAAAEN1cnJlbnQgZm9yY2UgYWN0aW5nIG9uIHRoZSBncmlwcGVyIGZpbmdlcnMALwA/" +
           "AzsAAAAL/////wEB/////wAAAAAEYIAKAQAAAAIABQAAAFJlYWR5AQHiOgAvAQK7OuI6AAAFAAAAADQB" +
           "AQHxOgAzAQEB8zoANAEBAfc6ADQBAQH/OgAzAQEBATsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJl" +
           "cgEB4zoALgBE4zoAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIABgAAAEhhbHRlZAEB5zoALwECuzrn" +
           "OgAABAAAAAAzAQEB8ToANAEBAfU6ADQBAQH9OgA0AQEBATsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51" +
           "bWJlcgEB6DoALgBE6DoAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIACQAAAFN1c3BlbmRlZAEB7DoA" +
           "LwECuzrsOgAABAAAAAA0AQEB+ToAMwEBAfs6ADMBAQH9OgAzAQEB/zoBAAAAFWCJCgIAAAAAAAsAAABT" +
           "dGF0ZU51bWJlcgEB7ToALgBE7ToAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIADQAAAEhhbHRlZFRv" +
           "UmVhZHkBAfE6AC8BAAYJ8ToAAAMAAAAAMwABAec6ADQAAQHiOgA2AAECwDoBAAAAFWCJCgIAAAAAABAA" +
           "AABUcmFuc2l0aW9uTnVtYmVyAQHyOgAuAETyOgAAAAf/////AQH/////AAAAAARggAoBAAAAAgAOAAAA" +
           "UmVhZHlUb1J1bm5pbmcBAfM6AC8BAAYJ8zoAAAMAAAAAMwABAeI6ADQAAQHdOgA2AAECwDoBAAAAFWCJ" +
           "CgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQH0OgAuAET0OgAAAAf/////AQH/////AAAAAARggAoB" +
           "AAAAAgAPAAAAUnVubmluZ1RvSGFsdGVkAQH1OgAvAQAGCfU6AAADAAAAADMAAQHdOgA0AAEB5zoANgAB" +
           "AsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB9joALgBE9joAAAAH/////wEB////" +
           "/wAAAAAEYIAKAQAAAAIADgAAAFJ1bm5pbmdUb1JlYWR5AQH3OgAvAQAGCfc6AAADAAAAADMAAQHdOgA0" +
           "AAEB4joANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB+DoALgBE+DoAAAAH" +
           "/////wEB/////wAAAAAEYIAKAQAAAAIAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEB+ToALwEABgn5OgAA" +
           "AwAAAAAzAAEB3ToANAABAew6ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIB" +
           "Afo6AC4ARPo6AAAAB/////8BAf////8AAAAABGCACgEAAAACABIAAABTdXNwZW5kZWRUb1J1bm5pbmcB" +
           "Afs6AC8BAAYJ+zoAAAMAAAAAMwABAew6ADQAAQHdOgA2AAECwDoBAAAAFWCJCgIAAAAAABAAAABUcmFu" +
           "c2l0aW9uTnVtYmVyAQH8OgAuAET8OgAAAAf/////AQH/////AAAAAARggAoBAAAAAgARAAAAU3VzcGVu" +
           "ZGVkVG9IYWx0ZWQBAf06AC8BAAYJ/ToAAAMAAAAAMwABAew6ADQAAQHnOgA2AAECwDoBAAAAFWCJCgIA" +
           "AAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQH+OgAuAET+OgAAAAf/////AQH/////AAAAAARggAoBAAAA" +
           "AgAQAAAAU3VzcGVuZGVkVG9SZWFkeQEB/zoALwEABgn/OgAAAwAAAAAzAAEB7DoANAABAeI6ADYAAQLA" +
           "OgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAQA7AC4ARAA7AAAAB/////8BAf////8A" +
           "AAAABGCACgEAAAACAA0AAABSZWFkeVRvSGFsdGVkAQEBOwAvAQAGCQE7AAADAAAAADMAAQHiOgA0AAEB" +
           "5zoANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBAjsALgBEAjsAAAAH////" +
           "/wEB/////wAAAAA=";
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
           "2joKOwAA/////w8AAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBCzsALwEAyAoLOwAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQw7AC4ARAw7AAAAEf////8BAf////8AAAAABGGCCgQA" +
           "AAACAAUAAABTdGFydAEBGDsALwEC6DoYOwAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1" +
           "bWVudHMBARk7AC4ARBk7AACWAQAAAAEAKgEBEwAAAAQAAABTcGFuAAv/////AAAAAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAAARggAoBAAAAAgAHAAAAUnVubmluZwEBJzsALwECuzonOwAABQAAAAA0AQEB" +
           "PTsAMwEBAT87ADMBAQFBOwAzAQEBQzsANAEBAUU7AQAAABVgiQoCAAAAAAALAAAAU3RhdGVOdW1iZXIB" +
           "ASg7AC4ARCg7AAAAB/////8BAf////8AAAAABGCACgEAAAACAAUAAABSZWFkeQEBLDsALwECuzosOwAA" +
           "BQAAAAA0AQEBOzsAMwEBAT07ADQBAQFBOwA0AQEBSTsAMwEBAUs7AQAAABVgiQoCAAAAAAALAAAAU3Rh" +
           "dGVOdW1iZXIBAS07AC4ARC07AAAAB/////8BAf////8AAAAABGCACgEAAAACAAYAAABIYWx0ZWQBATE7" +
           "AC8BArs6MTsAAAQAAAAAMwEBATs7ADQBAQE/OwA0AQEBRzsANAEBAUs7AQAAABVgiQoCAAAAAAALAAAA" +
           "U3RhdGVOdW1iZXIBATI7AC4ARDI7AAAAB/////8BAf////8AAAAABGCACgEAAAACAAkAAABTdXNwZW5k" +
           "ZWQBATY7AC8BArs6NjsAAAQAAAAANAEBAUM7ADMBAQFFOwAzAQEBRzsAMwEBAUk7AQAAABVgiQoCAAAA" +
           "AAALAAAAU3RhdGVOdW1iZXIBATc7AC4ARDc7AAAAB/////8BAf////8AAAAABGCACgEAAAACAA0AAABI" +
           "YWx0ZWRUb1JlYWR5AQE7OwAvAQAGCTs7AAADAAAAADMAAQExOwA0AAEBLDsANgABAsA6AQAAABVgiQoC" +
           "AAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBPDsALgBEPDsAAAAH/////wEB/////wAAAAAEYIAKAQAA" +
           "AAIADgAAAFJlYWR5VG9SdW5uaW5nAQE9OwAvAQAGCT07AAADAAAAADMAAQEsOwA0AAEBJzsANgABAsA6" +
           "AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBPjsALgBEPjsAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAIADwAAAFJ1bm5pbmdUb0hhbHRlZAEBPzsALwEABgk/OwAAAwAAAAAzAAEBJzsANAAB" +
           "ATE7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAUA7AC4AREA7AAAAB///" +
           "//8BAf////8AAAAABGCACgEAAAACAA4AAABSdW5uaW5nVG9SZWFkeQEBQTsALwEABglBOwAAAwAAAAAz" +
           "AAEBJzsANAABASw7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAUI7AC4A" +
           "REI7AAAAB/////8BAf////8AAAAABGCACgEAAAACABIAAABSdW5uaW5nVG9TdXNwZW5kZWQBAUM7AC8B" +
           "AAYJQzsAAAMAAAAAMwABASc7ADQAAQE2OwA2AAECwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9u" +
           "TnVtYmVyAQFEOwAuAEREOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgASAAAAU3VzcGVuZGVkVG9S" +
           "dW5uaW5nAQFFOwAvAQAGCUU7AAADAAAAADMAAQE2OwA0AAEBJzsANgABAsA6AQAAABVgiQoCAAAAAAAQ" +
           "AAAAVHJhbnNpdGlvbk51bWJlcgEBRjsALgBERjsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIAEQAA" +
           "AFN1c3BlbmRlZFRvSGFsdGVkAQFHOwAvAQAGCUc7AAADAAAAADMAAQE2OwA0AAEBMTsANgABAsA6AQAA" +
           "ABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBSDsALgBESDsAAAAH/////wEB/////wAAAAAE" +
           "YIAKAQAAAAIAEAAAAFN1c3BlbmRlZFRvUmVhZHkBAUk7AC8BAAYJSTsAAAMAAAAAMwABATY7ADQAAQEs" +
           "OwA2AAECwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFKOwAuAERKOwAAAAf/////" +
           "AQH/////AAAAAARggAoBAAAAAgANAAAAUmVhZHlUb0hhbHRlZAEBSzsALwEABglLOwAAAwAAAAAzAAEB" +
           "LDsANAABATE7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAUw7AC4AREw7" +
           "AAAAB/////8BAf////8AAAAA";
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
           "bmUBAVM7AC8BAto6UzsAAP////8PAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAVQ7AC8BAMgK" +
           "VDsAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFVOwAuAERVOwAAABH/////AQH/////" +
           "AAAAAARhggoEAAAAAgAFAAAAU3RhcnQBAWE7AC8BAug6YTsAAAEB/////wEAAAAXYKkKAgAAAAAADgAA" +
           "AElucHV0QXJndW1lbnRzAQFiOwAuAERiOwAAlgEAAAABACoBARcAAAAIAAAAUG9zaXRpb24AC/////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGCACgEAAAACAAcAAABSdW5uaW5nAQFwOwAvAQK7" +
           "OnA7AAAFAAAAADQBAQGGOwAzAQEBiDsAMwEBAYo7ADMBAQGMOwA0AQEBjjsCAAAAFWCJCgIAAAAAAAsA" +
           "AABTdGF0ZU51bWJlcgEBcTsALgBEcTsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIAEwAAAENvbnRp" +
           "bnVvdXNQYXJhbWV0ZXIBAXI7AC8AOnI7AAD/////AQAAAARggAoBAAAAAgAPAAAAT3V0cHV0UGFyYW1l" +
           "dGVyAQF0OwAvADp0OwAA/////wEAAAA1YIkKAgAAAAEADwAAAEN1cnJlbnRQb3NpdGlvbgEBljsDAAAA" +
           "ACMAAABDdXJyZW50IHBvc2l0aW9uIG9mIHRoZSBsaW5lYXIgYXhpcwAvAD+WOwAAAAv/////AQH/////" +
           "AAAAAARggAoBAAAAAgAFAAAAUmVhZHkBAXU7AC8BArs6dTsAAAUAAAAANAEBAYQ7ADMBAQGGOwA0AQEB" +
           "ijsANAEBAZI7ADMBAQGUOwEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQF2OwAuAER2OwAAAAf/" +
           "////AQH/////AAAAAARggAoBAAAAAgAGAAAASGFsdGVkAQF6OwAvAQK7Ono7AAAEAAAAADMBAQGEOwA0" +
           "AQEBiDsANAEBAZA7ADQBAQGUOwEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQF7OwAuAER7OwAA" +
           "AAf/////AQH/////AAAAAARggAoBAAAAAgAJAAAAU3VzcGVuZGVkAQF/OwAvAQK7On87AAAEAAAAADQB" +
           "AQGMOwAzAQEBjjsAMwEBAZA7ADMBAQGSOwEAAAAVYIkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQGAOwAu" +
           "AESAOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgANAAAASGFsdGVkVG9SZWFkeQEBhDsALwEABgmE" +
           "OwAAAwAAAAAzAAEBejsANAABAXU7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1i" +
           "ZXIBAYU7AC4ARIU7AAAAB/////8BAf////8AAAAABGCACgEAAAACAA4AAABSZWFkeVRvUnVubmluZwEB" +
           "hjsALwEABgmGOwAAAwAAAAAzAAEBdTsANAABAXA7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5z" +
           "aXRpb25OdW1iZXIBAYc7AC4ARIc7AAAAB/////8BAf////8AAAAABGCACgEAAAACAA8AAABSdW5uaW5n" +
           "VG9IYWx0ZWQBAYg7AC8BAAYJiDsAAAMAAAAAMwABAXA7ADQAAQF6OwA2AAECwDoBAAAAFWCJCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQGJOwAuAESJOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgAO" +
           "AAAAUnVubmluZ1RvUmVhZHkBAYo7AC8BAAYJijsAAAMAAAAAMwABAXA7ADQAAQF1OwA2AAECwDoBAAAA" +
           "FWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQGLOwAuAESLOwAAAAf/////AQH/////AAAAAARg" +
           "gAoBAAAAAgASAAAAUnVubmluZ1RvU3VzcGVuZGVkAQGMOwAvAQAGCYw7AAADAAAAADMAAQFwOwA0AAEB" +
           "fzsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBjTsALgBEjTsAAAAH////" +
           "/wEB/////wAAAAAEYIAKAQAAAAIAEgAAAFN1c3BlbmRlZFRvUnVubmluZwEBjjsALwEABgmOOwAAAwAA" +
           "AAAzAAEBfzsANAABAXA7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAY87" +
           "AC4ARI87AAAAB/////8BAf////8AAAAABGCACgEAAAACABEAAABTdXNwZW5kZWRUb0hhbHRlZAEBkDsA" +
           "LwEABgmQOwAAAwAAAAAzAAEBfzsANAABAXo7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRp" +
           "b25OdW1iZXIBAZE7AC4ARJE7AAAAB/////8BAf////8AAAAABGCACgEAAAACABAAAABTdXNwZW5kZWRU" +
           "b1JlYWR5AQGSOwAvAQAGCZI7AAADAAAAADMAAQF/OwA0AAEBdTsANgABAsA6AQAAABVgiQoCAAAAAAAQ" +
           "AAAAVHJhbnNpdGlvbk51bWJlcgEBkzsALgBEkzsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIADQAA" +
           "AFJlYWR5VG9IYWx0ZWQBAZQ7AC8BAAYJlDsAAAMAAAAAMwABAXU7ADQAAQF6OwA2AAECwDoBAAAAFWCJ" +
           "CgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQGVOwAuAESVOwAAAAf/////AQH/////AAAAAA==";
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
           "nTsAAP////8PAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAZ47AC8BAMgKnjsAAAAV/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQGfOwAuAESfOwAAABH/////AQH/////AAAAAARhggoEAAAA" +
           "AgAFAAAAU3RhcnQBAas7AC8BAug6qzsAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQGsOwAuAESsOwAAlgEAAAABACoBARcAAAAIAAAAUG9zaXRpb24AC/////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAAAAAABAf////8AAAAABGCACgEAAAACAAcAAABSdW5uaW5nAQG6OwAvAQK7Oro7AAAFAAAAADQB" +
           "AQHQOwAzAQEB0jsAMwEBAdQ7ADMBAQHWOwA0AQEB2DsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJl" +
           "cgEBuzsALgBEuzsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIABQAAAFJlYWR5AQG/OwAvAQK7Or87" +
           "AAAFAAAAADQBAQHOOwAzAQEB0DsANAEBAdQ7ADQBAQHcOwAzAQEB3jsBAAAAFWCJCgIAAAAAAAsAAABT" +
           "dGF0ZU51bWJlcgEBwDsALgBEwDsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIABgAAAEhhbHRlZAEB" +
           "xDsALwECuzrEOwAABAAAAAAzAQEBzjsANAEBAdI7ADQBAQHaOwA0AQEB3jsBAAAAFWCJCgIAAAAAAAsA" +
           "AABTdGF0ZU51bWJlcgEBxTsALgBExTsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIACQAAAFN1c3Bl" +
           "bmRlZAEByTsALwECuzrJOwAABAAAAAA0AQEB1jsAMwEBAdg7ADMBAQHaOwAzAQEB3DsBAAAAFWCJCgIA" +
           "AAAAAAsAAABTdGF0ZU51bWJlcgEByjsALgBEyjsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIADQAA" +
           "AEhhbHRlZFRvUmVhZHkBAc47AC8BAAYJzjsAAAMAAAAAMwABAcQ7ADQAAQG/OwA2AAECwDoBAAAAFWCJ" +
           "CgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHPOwAuAETPOwAAAAf/////AQH/////AAAAAARggAoB" +
           "AAAAAgAOAAAAUmVhZHlUb1J1bm5pbmcBAdA7AC8BAAYJ0DsAAAMAAAAAMwABAb87ADQAAQG6OwA2AAEC" +
           "wDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHROwAuAETROwAAAAf/////AQH/////" +
           "AAAAAARggAoBAAAAAgAPAAAAUnVubmluZ1RvSGFsdGVkAQHSOwAvAQAGCdI7AAADAAAAADMAAQG6OwA0" +
           "AAEBxDsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB0zsALgBE0zsAAAAH" +
           "/////wEB/////wAAAAAEYIAKAQAAAAIADgAAAFJ1bm5pbmdUb1JlYWR5AQHUOwAvAQAGCdQ7AAADAAAA" +
           "ADMAAQG6OwA0AAEBvzsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB1TsA" +
           "LgBE1TsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAIAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEB1jsA" +
           "LwEABgnWOwAAAwAAAAAzAAEBujsANAABAck7ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRp" +
           "b25OdW1iZXIBAdc7AC4ARNc7AAAAB/////8BAf////8AAAAABGCACgEAAAACABIAAABTdXNwZW5kZWRU" +
           "b1J1bm5pbmcBAdg7AC8BAAYJ2DsAAAMAAAAAMwABAck7ADQAAQG6OwA2AAECwDoBAAAAFWCJCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQHZOwAuAETZOwAAAAf/////AQH/////AAAAAARggAoBAAAAAgAR" +
           "AAAAU3VzcGVuZGVkVG9IYWx0ZWQBAdo7AC8BAAYJ2jsAAAMAAAAAMwABAck7ADQAAQHEOwA2AAECwDoB" +
           "AAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQHbOwAuAETbOwAAAAf/////AQH/////AAAA" +
           "AARggAoBAAAAAgAQAAAAU3VzcGVuZGVkVG9SZWFkeQEB3DsALwEABgncOwAAAwAAAAAzAAEByTsANAAB" +
           "Ab87ADYAAQLAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAd07AC4ARN07AAAAB///" +
           "//8BAf////8AAAAABGCACgEAAAACAA0AAABSZWFkeVRvSGFsdGVkAQHeOwAvAQAGCd47AAADAAAAADMA" +
           "AQG/OwA0AAEBxDsANgABAsA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB3zsALgBE" +
           "3zsAAAAH/////wEB/////wAAAAA=";
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