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

namespace Opc.Ua.Skills
{
    #region SkillStateState Class
    #if (!OPCUA_EXCLUDE_SkillStateState)
    /// <summary>
    /// Stores an instance of the SkillStateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillStateState : StateMachineStateState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillStateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Skills.ObjectTypes.SkillStateType, Opc.Ua.Skills.Namespaces.OpcUaSkills, namespaceUris);
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

            if (ContinuousParameter != null)
            {
                ContinuousParameter.Initialize(context, ContinuousParameter_InitializationString);
            }
        }

        #region Initialization String
        private const string ContinuousParameter_InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////8EYIAKAQAAAAEAEwAA" +
           "AENvbnRpbnVvdXNQYXJhbWV0ZXIBAb06AC8AOr06AAD/////AgAAAARggAoBAAAAAQAOAAAASW5wdXRQ" +
           "YXJhbWV0ZXIBAb46AC8AOr46AAD/////AAAAAARggAoBAAAAAQAPAAAAT3V0cHV0UGFyYW1ldGVyAQG/" +
           "OgAvADq/OgAA/////wAAAAA=";

        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////8EYIACAQAAAAEAFgAA" +
           "AFNraWxsU3RhdGVUeXBlSW5zdGFuY2UBAbs6AQG7Ors6AAD/////AgAAABVgiQoCAAAAAAALAAAAU3Rh" +
           "dGVOdW1iZXIBAbw6AC4ARLw6AAAAB/////8BAf////8AAAAABGCACgEAAAABABMAAABDb250aW51b3Vz" +
           "UGFyYW1ldGVyAQG9OgAvADq9OgAA/////wIAAAAEYIAKAQAAAAEADgAAAElucHV0UGFyYW1ldGVyAQG+" +
           "OgAvADq+OgAA/////wAAAAAEYIAKAQAAAAEADwAAAE91dHB1dFBhcmFtZXRlcgEBvzoALwA6vzoAAP//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState ContinuousParameter
        {
            get
            {
                return m_continuousParameter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_continuousParameter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_continuousParameter = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_continuousParameter != null)
            {
                children.Add(m_continuousParameter);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Skills.BrowseNames.ContinuousParameter:
                {
                    if (createOrReplace)
                    {
                        if (ContinuousParameter == null)
                        {
                            if (replacement == null)
                            {
                                ContinuousParameter = new BaseObjectState(this);
                            }
                            else
                            {
                                ContinuousParameter = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ContinuousParameter;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_continuousParameter;
        #endregion
    }
    #endif
    #endregion

    #region SkillStateTransitionEventState Class
    #if (!OPCUA_EXCLUDE_SkillStateTransitionEventState)
    /// <summary>
    /// Stores an instance of the SkillStateTransitionEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillStateTransitionEventState : TransitionEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillStateTransitionEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Skills.ObjectTypes.SkillStateTransitionEventType, Opc.Ua.Skills.Namespaces.OpcUaSkills, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////8EYIACAQAAAAEAJQAA" +
           "AFNraWxsU3RhdGVUcmFuc2l0aW9uRXZlbnRUeXBlSW5zdGFuY2UBAcA6AQHAOsA6AAD/////CwAAABVg" +
           "iQoCAAAAAAAHAAAARXZlbnRJZAEBwToALgBEwToAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAA" +
           "AEV2ZW50VHlwZQEBwjoALgBEwjoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5v" +
           "ZGUBAcM6AC4ARMM6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHEOgAu" +
           "AETEOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBxToALgBExToAAAEAJgH/////" +
           "AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAcY6AC4ARMY6AAABACYB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAcg6AC4ARMg6AAAAFf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAgAAABTZXZlcml0eQEByToALgBEyToAAAAF/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFRy" +
           "YW5zaXRpb24BAco6AC8BAMoKyjoAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQHLOgAu" +
           "AETLOgAAABj/////AQH/////AAAAABVgiQoCAAAAAAAJAAAARnJvbVN0YXRlAQHQOgAvAQDDCtA6AAAA" +
           "Ff////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEB0ToALgBE0ToAAAAY/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAABwAAAFRvU3RhdGUBAdU6AC8BAMMK1ToAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAA" +
           "AgAAAElkAQHWOgAuAETWOgAAABj/////AQH/////AAAAAA==";
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

    #region SkillStateMachineState Class
    #if (!OPCUA_EXCLUDE_SkillStateMachineState)
    /// <summary>
    /// Stores an instance of the SkillStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillStateMachineState : FiniteStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Skills.ObjectTypes.SkillStateMachineType, Opc.Ua.Skills.Namespaces.OpcUaSkills, namespaceUris);
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
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////+EYIACAQAAAAEAHQAA" +
           "AFNraWxsU3RhdGVNYWNoaW5lVHlwZUluc3RhbmNlAQHaOgEB2jraOgAAAf////8UAAAAFWCJCgIAAAAA" +
           "AAwAAABDdXJyZW50U3RhdGUBAds6AC8BAMgK2zoAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQHcOgAuAETcOgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAOAAAATGFzdFRyYW5zaXRpb24B" +
           "AeA6AC8BAMoK4DoAAAAV/////wEB/////wIAAAAVYIkKAgAAAAAAAgAAAElkAQHhOgAuAEThOgAAABH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAOAAAAVHJhbnNpdGlvblRpbWUBAeQ6AC4AROQ6AAABACYB////" +
           "/wEB/////wAAAAAEYYIKBAAAAAEABQAAAFN0YXJ0AQHoOgAvAQHoOug6AAABAf////8AAAAABGGCCgQA" +
           "AAABAAQAAABIYWx0AQHrOgAvAQHrOus6AAABAf////8AAAAABGGCCgQAAAABAAUAAABSZXNldAEB7joA" +
           "LwEB7jruOgAAAQH/////AAAAAARhggoEAAAAAQAGAAAAUmVzdW1lAQHxOgAvAQHxOvE6AAABAf////8A" +
           "AAAABGGCCgQAAAABAAcAAABTdXNwZW5kAQH0OgAvAQH0OvQ6AAABAf////8AAAAABGCACgEAAAABAAcA" +
           "AABSdW5uaW5nAQH3OgAvAQG7Ovc6AAAFAAAAADQBAQENOwAzAQEBDzsAMwEBARE7ADMBAQETOwA0AQEB" +
           "FTsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB+DoALgBE+DoAAAAH/////wEB/////wAAAAAE" +
           "YIAKAQAAAAEABQAAAFJlYWR5AQH8OgAvAQG7Ovw6AAAFAAAAADQBAQELOwAzAQEBDTsANAEBARE7ADQB" +
           "AQEZOwAzAQEBGzsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB/ToALgBE/ToAAAAH/////wEB" +
           "/////wAAAAAEYIAKAQAAAAEABgAAAEhhbHRlZAEBATsALwEBuzoBOwAABAAAAAAzAQEBCzsANAEBAQ87" +
           "ADQBAQEXOwA0AQEBGzsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBAjsALgBEAjsAAAAH////" +
           "/wEB/////wAAAAAEYIAKAQAAAAEACQAAAFN1c3BlbmRlZAEBBjsALwEBuzoGOwAABAAAAAA0AQEBEzsA" +
           "MwEBARU7ADMBAQEXOwAzAQEBGTsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBBzsALgBEBzsA" +
           "AAAH/////wEB/////wAAAAAEYIAKAQAAAAEADQAAAEhhbHRlZFRvUmVhZHkBAQs7AC8BAAYJCzsAAAMA" +
           "AAAAMwABAQE7ADQAAQH8OgA2AAEBwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQEM" +
           "OwAuAEQMOwAAAAf/////AQH/////AAAAAARggAoBAAAAAQAOAAAAUmVhZHlUb1J1bm5pbmcBAQ07AC8B" +
           "AAYJDTsAAAMAAAAAMwABAfw6ADQAAQH3OgA2AAEBwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9u" +
           "TnVtYmVyAQEOOwAuAEQOOwAAAAf/////AQH/////AAAAAARggAoBAAAAAQAPAAAAUnVubmluZ1RvSGFs" +
           "dGVkAQEPOwAvAQAGCQ87AAADAAAAADMAAQH3OgA0AAEBATsANgABAcA6AQAAABVgiQoCAAAAAAAQAAAA" +
           "VHJhbnNpdGlvbk51bWJlcgEBEDsALgBEEDsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEADgAAAFJ1" +
           "bm5pbmdUb1JlYWR5AQEROwAvAQAGCRE7AAADAAAAADMAAQH3OgA0AAEB/DoANgABAcA6AQAAABVgiQoC" +
           "AAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBEjsALgBEEjsAAAAH/////wEB/////wAAAAAEYIAKAQAA" +
           "AAEAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEBEzsALwEABgkTOwAAAwAAAAAzAAEB9zoANAABAQY7ADYA" +
           "AQHAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBARQ7AC4ARBQ7AAAAB/////8BAf//" +
           "//8AAAAABGCACgEAAAABABIAAABTdXNwZW5kZWRUb1J1bm5pbmcBARU7AC8BAAYJFTsAAAMAAAAAMwAB" +
           "AQY7ADQAAQH3OgA2AAEBwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQEWOwAuAEQW" +
           "OwAAAAf/////AQH/////AAAAAARggAoBAAAAAQARAAAAU3VzcGVuZGVkVG9IYWx0ZWQBARc7AC8BAAYJ" +
           "FzsAAAMAAAAAMwABAQY7ADQAAQEBOwA2AAEBwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0aW9uTnVt" +
           "YmVyAQEYOwAuAEQYOwAAAAf/////AQH/////AAAAAARggAoBAAAAAQAQAAAAU3VzcGVuZGVkVG9SZWFk" +
           "eQEBGTsALwEABgkZOwAAAwAAAAAzAAEBBjsANAABAfw6ADYAAQHAOgEAAAAVYIkKAgAAAAAAEAAAAFRy" +
           "YW5zaXRpb25OdW1iZXIBARo7AC4ARBo7AAAAB/////8BAf////8AAAAABGCACgEAAAABAA0AAABSZWFk" +
           "eVRvSGFsdGVkAQEbOwAvAQAGCRs7AAADAAAAADMAAQH8OgA0AAEBATsANgABAcA6AQAAABVgiQoCAAAA" +
           "AAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBHDsALgBEHDsAAAAH/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }

        /// <remarks />
        public MethodState Halt
        {
            get
            {
                return m_haltMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_haltMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_haltMethod = value;
            }
        }

        /// <remarks />
        public MethodState Reset
        {
            get
            {
                return m_resetMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resetMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resetMethod = value;
            }
        }

        /// <remarks />
        public MethodState Resume
        {
            get
            {
                return m_resumeMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resumeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resumeMethod = value;
            }
        }

        /// <remarks />
        public MethodState Suspend
        {
            get
            {
                return m_suspendMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendMethod = value;
            }
        }

        /// <remarks />
        public SkillStateState Running
        {
            get
            {
                return m_running;
            }

            set
            {
                if (!Object.ReferenceEquals(m_running, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_running = value;
            }
        }

        /// <remarks />
        public SkillStateState Ready
        {
            get
            {
                return m_ready;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ready, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ready = value;
            }
        }

        /// <remarks />
        public SkillStateState Halted
        {
            get
            {
                return m_halted;
            }

            set
            {
                if (!Object.ReferenceEquals(m_halted, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_halted = value;
            }
        }

        /// <remarks />
        public SkillStateState Suspended
        {
            get
            {
                return m_suspended;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspended, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspended = value;
            }
        }

        /// <remarks />
        public new TransitionVariableState LastTransition
        {
            get { return (TransitionVariableState)base.LastTransition; }
            set { base.LastTransition = value; }
        }

        /// <remarks />
        public StateMachineTransitionState HaltedToReady
        {
            get
            {
                return m_haltedToReady;
            }

            set
            {
                if (!Object.ReferenceEquals(m_haltedToReady, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_haltedToReady = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState ReadyToRunning
        {
            get
            {
                return m_readyToRunning;
            }

            set
            {
                if (!Object.ReferenceEquals(m_readyToRunning, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_readyToRunning = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState RunningToHalted
        {
            get
            {
                return m_runningToHalted;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runningToHalted, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runningToHalted = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState RunningToReady
        {
            get
            {
                return m_runningToReady;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runningToReady, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runningToReady = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState RunningToSuspended
        {
            get
            {
                return m_runningToSuspended;
            }

            set
            {
                if (!Object.ReferenceEquals(m_runningToSuspended, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_runningToSuspended = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState SuspendedToRunning
        {
            get
            {
                return m_suspendedToRunning;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendedToRunning, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendedToRunning = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState SuspendedToHalted
        {
            get
            {
                return m_suspendedToHalted;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendedToHalted, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendedToHalted = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState SuspendedToReady
        {
            get
            {
                return m_suspendedToReady;
            }

            set
            {
                if (!Object.ReferenceEquals(m_suspendedToReady, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_suspendedToReady = value;
            }
        }

        /// <remarks />
        public StateMachineTransitionState ReadyToHalted
        {
            get
            {
                return m_readyToHalted;
            }

            set
            {
                if (!Object.ReferenceEquals(m_readyToHalted, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_readyToHalted = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_haltMethod != null)
            {
                children.Add(m_haltMethod);
            }

            if (m_resetMethod != null)
            {
                children.Add(m_resetMethod);
            }

            if (m_resumeMethod != null)
            {
                children.Add(m_resumeMethod);
            }

            if (m_suspendMethod != null)
            {
                children.Add(m_suspendMethod);
            }

            if (m_running != null)
            {
                children.Add(m_running);
            }

            if (m_ready != null)
            {
                children.Add(m_ready);
            }

            if (m_halted != null)
            {
                children.Add(m_halted);
            }

            if (m_suspended != null)
            {
                children.Add(m_suspended);
            }

            if (m_haltedToReady != null)
            {
                children.Add(m_haltedToReady);
            }

            if (m_readyToRunning != null)
            {
                children.Add(m_readyToRunning);
            }

            if (m_runningToHalted != null)
            {
                children.Add(m_runningToHalted);
            }

            if (m_runningToReady != null)
            {
                children.Add(m_runningToReady);
            }

            if (m_runningToSuspended != null)
            {
                children.Add(m_runningToSuspended);
            }

            if (m_suspendedToRunning != null)
            {
                children.Add(m_suspendedToRunning);
            }

            if (m_suspendedToHalted != null)
            {
                children.Add(m_suspendedToHalted);
            }

            if (m_suspendedToReady != null)
            {
                children.Add(m_suspendedToReady);
            }

            if (m_readyToHalted != null)
            {
                children.Add(m_readyToHalted);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Skills.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Halt:
                {
                    if (createOrReplace)
                    {
                        if (Halt == null)
                        {
                            if (replacement == null)
                            {
                                Halt = new MethodState(this);
                            }
                            else
                            {
                                Halt = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Halt;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Reset:
                {
                    if (createOrReplace)
                    {
                        if (Reset == null)
                        {
                            if (replacement == null)
                            {
                                Reset = new MethodState(this);
                            }
                            else
                            {
                                Reset = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Reset;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Resume:
                {
                    if (createOrReplace)
                    {
                        if (Resume == null)
                        {
                            if (replacement == null)
                            {
                                Resume = new MethodState(this);
                            }
                            else
                            {
                                Resume = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Resume;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Suspend:
                {
                    if (createOrReplace)
                    {
                        if (Suspend == null)
                        {
                            if (replacement == null)
                            {
                                Suspend = new MethodState(this);
                            }
                            else
                            {
                                Suspend = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Suspend;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Running:
                {
                    if (createOrReplace)
                    {
                        if (Running == null)
                        {
                            if (replacement == null)
                            {
                                Running = new SkillStateState(this);
                            }
                            else
                            {
                                Running = (SkillStateState)replacement;
                            }
                        }
                    }

                    instance = Running;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Ready:
                {
                    if (createOrReplace)
                    {
                        if (Ready == null)
                        {
                            if (replacement == null)
                            {
                                Ready = new SkillStateState(this);
                            }
                            else
                            {
                                Ready = (SkillStateState)replacement;
                            }
                        }
                    }

                    instance = Ready;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Halted:
                {
                    if (createOrReplace)
                    {
                        if (Halted == null)
                        {
                            if (replacement == null)
                            {
                                Halted = new SkillStateState(this);
                            }
                            else
                            {
                                Halted = (SkillStateState)replacement;
                            }
                        }
                    }

                    instance = Halted;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Suspended:
                {
                    if (createOrReplace)
                    {
                        if (Suspended == null)
                        {
                            if (replacement == null)
                            {
                                Suspended = new SkillStateState(this);
                            }
                            else
                            {
                                Suspended = (SkillStateState)replacement;
                            }
                        }
                    }

                    instance = Suspended;
                    break;
                }

                case Opc.Ua.BrowseNames.LastTransition:
                {
                    if (createOrReplace)
                    {
                        if (LastTransition == null)
                        {
                            if (replacement == null)
                            {
                                LastTransition = new TransitionVariableState(this);
                            }
                            else
                            {
                                LastTransition = (TransitionVariableState)replacement;
                            }
                        }
                    }

                    instance = LastTransition;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.HaltedToReady:
                {
                    if (createOrReplace)
                    {
                        if (HaltedToReady == null)
                        {
                            if (replacement == null)
                            {
                                HaltedToReady = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                HaltedToReady = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = HaltedToReady;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.ReadyToRunning:
                {
                    if (createOrReplace)
                    {
                        if (ReadyToRunning == null)
                        {
                            if (replacement == null)
                            {
                                ReadyToRunning = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                ReadyToRunning = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = ReadyToRunning;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.RunningToHalted:
                {
                    if (createOrReplace)
                    {
                        if (RunningToHalted == null)
                        {
                            if (replacement == null)
                            {
                                RunningToHalted = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                RunningToHalted = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = RunningToHalted;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.RunningToReady:
                {
                    if (createOrReplace)
                    {
                        if (RunningToReady == null)
                        {
                            if (replacement == null)
                            {
                                RunningToReady = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                RunningToReady = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = RunningToReady;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.RunningToSuspended:
                {
                    if (createOrReplace)
                    {
                        if (RunningToSuspended == null)
                        {
                            if (replacement == null)
                            {
                                RunningToSuspended = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                RunningToSuspended = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = RunningToSuspended;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.SuspendedToRunning:
                {
                    if (createOrReplace)
                    {
                        if (SuspendedToRunning == null)
                        {
                            if (replacement == null)
                            {
                                SuspendedToRunning = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                SuspendedToRunning = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = SuspendedToRunning;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.SuspendedToHalted:
                {
                    if (createOrReplace)
                    {
                        if (SuspendedToHalted == null)
                        {
                            if (replacement == null)
                            {
                                SuspendedToHalted = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                SuspendedToHalted = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = SuspendedToHalted;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.SuspendedToReady:
                {
                    if (createOrReplace)
                    {
                        if (SuspendedToReady == null)
                        {
                            if (replacement == null)
                            {
                                SuspendedToReady = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                SuspendedToReady = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = SuspendedToReady;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.ReadyToHalted:
                {
                    if (createOrReplace)
                    {
                        if (ReadyToHalted == null)
                        {
                            if (replacement == null)
                            {
                                ReadyToHalted = new StateMachineTransitionState(this);
                            }
                            else
                            {
                                ReadyToHalted = (StateMachineTransitionState)replacement;
                            }
                        }
                    }

                    instance = ReadyToHalted;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MethodState m_startMethod;
        private MethodState m_haltMethod;
        private MethodState m_resetMethod;
        private MethodState m_resumeMethod;
        private MethodState m_suspendMethod;
        private SkillStateState m_running;
        private SkillStateState m_ready;
        private SkillStateState m_halted;
        private SkillStateState m_suspended;
        private StateMachineTransitionState m_haltedToReady;
        private StateMachineTransitionState m_readyToRunning;
        private StateMachineTransitionState m_runningToHalted;
        private StateMachineTransitionState m_runningToReady;
        private StateMachineTransitionState m_runningToSuspended;
        private StateMachineTransitionState m_suspendedToRunning;
        private StateMachineTransitionState m_suspendedToHalted;
        private StateMachineTransitionState m_suspendedToReady;
        private StateMachineTransitionState m_readyToHalted;
        #endregion
    }
    #endif
    #endregion

    #region SkillState Class
    #if (!OPCUA_EXCLUDE_SkillState)
    /// <summary>
    /// Stores an instance of the SkillType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SkillState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SkillState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Skills.ObjectTypes.SkillType, Opc.Ua.Skills.Namespaces.OpcUaSkills, namespaceUris);
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

            if (Functionality != null)
            {
                Functionality.Initialize(context, Functionality_InitializationString);
            }
        }

        #region Initialization String
        private const string Functionality_InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////8kYIAKAQAAAAEADQAA" +
           "AEZ1bmN0aW9uYWxpdHkBASA7AwAAAAB2AAAAT2JqZWN0IGRlc2NyaWJpbmcgdGhlIHNraWxsIGZ1bmN0" +
           "aW9uYWxpdHkgYnkgcmVmZXJlbmNpbmcgYSBEaXNjdGlvbmFyeUVudHJ5IHdpdGggcmVmZXJlbmNlIHR5" +
           "cGUgSGFzRGljdGlvbmFyeUVudHJ5VHlwZQAvADogOwAA/////wAAAAA=";

        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2tpbGxzL/////+EYIACAQAAAAEAEQAA" +
           "AFNraWxsVHlwZUluc3RhbmNlAQEdOwEBHTsdOwAAAf////8EAAAAFWCJCgIAAAABAAoAAABJZGVudGlm" +
           "aWVyAQEeOwAuAEQeOwAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAOAAAASXNJbnN0YW50aWFibGUB" +
           "AR87AC4ARB87AAAAAf////8BAf////8AAAAAJGCACgEAAAABAA0AAABGdW5jdGlvbmFsaXR5AQEgOwMA" +
           "AAAAdgAAAE9iamVjdCBkZXNjcmliaW5nIHRoZSBza2lsbCBmdW5jdGlvbmFsaXR5IGJ5IHJlZmVyZW5j" +
           "aW5nIGEgRGlzY3Rpb25hcnlFbnRyeSB3aXRoIHJlZmVyZW5jZSB0eXBlIEhhc0RpY3Rpb25hcnlFbnRy" +
           "eVR5cGUALwA6IDsAAP////8AAAAABGCACgEAAAABAAwAAABTdGF0ZU1hY2hpbmUBASE7AC8BAdo6ITsA" +
           "AP////8UAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBASI7AC8BAMgKIjsAAAAV/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAAgAAAElkAQEjOwAuAEQjOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAO" +
           "AAAATGFzdFRyYW5zaXRpb24BASc7AC8BAMoKJzsAAAAV/////wEB/////wIAAAAVYIkKAgAAAAAAAgAA" +
           "AElkAQEoOwAuAEQoOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAOAAAAVHJhbnNpdGlvblRpbWUB" +
           "ASs7AC4ARCs7AAABACYB/////wEB/////wAAAAAEYYIKBAAAAAEABQAAAFN0YXJ0AQEvOwAvAQHoOi87" +
           "AAABAf////8AAAAABGGCCgQAAAABAAQAAABIYWx0AQEyOwAvAQHrOjI7AAABAf////8AAAAABGGCCgQA" +
           "AAABAAUAAABSZXNldAEBNTsALwEB7jo1OwAAAQH/////AAAAAARhggoEAAAAAQAGAAAAUmVzdW1lAQE4" +
           "OwAvAQHxOjg7AAABAf////8AAAAABGGCCgQAAAABAAcAAABTdXNwZW5kAQE7OwAvAQH0Ojs7AAABAf//" +
           "//8AAAAABGCACgEAAAABAAcAAABSdW5uaW5nAQE+OwAvAQG7Oj47AAAFAAAAADQBAQFUOwAzAQEBVjsA" +
           "MwEBAVg7ADMBAQFaOwA0AQEBXDsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBPzsALgBEPzsA" +
           "AAAH/////wEB/////wAAAAAEYIAKAQAAAAEABQAAAFJlYWR5AQFDOwAvAQG7OkM7AAAFAAAAADQBAQFS" +
           "OwAzAQEBVDsANAEBAVg7ADQBAQFgOwAzAQEBYjsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB" +
           "RDsALgBERDsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEABgAAAEhhbHRlZAEBSDsALwEBuzpIOwAA" +
           "BAAAAAAzAQEBUjsANAEBAVY7ADQBAQFeOwA0AQEBYjsBAAAAFWCJCgIAAAAAAAsAAABTdGF0ZU51bWJl" +
           "cgEBSTsALgBESTsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEACQAAAFN1c3BlbmRlZAEBTTsALwEB" +
           "uzpNOwAABAAAAAA0AQEBWjsAMwEBAVw7ADMBAQFeOwAzAQEBYDsBAAAAFWCJCgIAAAAAAAsAAABTdGF0" +
           "ZU51bWJlcgEBTjsALgBETjsAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEADQAAAEhhbHRlZFRvUmVh" +
           "ZHkBAVI7AC8BAAYJUjsAAAMAAAAAMwABAUg7ADQAAQFDOwA2AAEBwDoBAAAAFWCJCgIAAAAAABAAAABU" +
           "cmFuc2l0aW9uTnVtYmVyAQFTOwAuAERTOwAAAAf/////AQH/////AAAAAARggAoBAAAAAQAOAAAAUmVh" +
           "ZHlUb1J1bm5pbmcBAVQ7AC8BAAYJVDsAAAMAAAAAMwABAUM7ADQAAQE+OwA2AAEBwDoBAAAAFWCJCgIA" +
           "AAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFVOwAuAERVOwAAAAf/////AQH/////AAAAAARggAoBAAAA" +
           "AQAPAAAAUnVubmluZ1RvSGFsdGVkAQFWOwAvAQAGCVY7AAADAAAAADMAAQE+OwA0AAEBSDsANgABAcA6" +
           "AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBVzsALgBEVzsAAAAH/////wEB/////wAA" +
           "AAAEYIAKAQAAAAEADgAAAFJ1bm5pbmdUb1JlYWR5AQFYOwAvAQAGCVg7AAADAAAAADMAAQE+OwA0AAEB" +
           "QzsANgABAcA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBWTsALgBEWTsAAAAH////" +
           "/wEB/////wAAAAAEYIAKAQAAAAEAEgAAAFJ1bm5pbmdUb1N1c3BlbmRlZAEBWjsALwEABglaOwAAAwAA" +
           "AAAzAAEBPjsANAABAU07ADYAAQHAOgEAAAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAVs7" +
           "AC4ARFs7AAAAB/////8BAf////8AAAAABGCACgEAAAABABIAAABTdXNwZW5kZWRUb1J1bm5pbmcBAVw7" +
           "AC8BAAYJXDsAAAMAAAAAMwABAU07ADQAAQE+OwA2AAEBwDoBAAAAFWCJCgIAAAAAABAAAABUcmFuc2l0" +
           "aW9uTnVtYmVyAQFdOwAuAERdOwAAAAf/////AQH/////AAAAAARggAoBAAAAAQARAAAAU3VzcGVuZGVk" +
           "VG9IYWx0ZWQBAV47AC8BAAYJXjsAAAMAAAAAMwABAU07ADQAAQFIOwA2AAEBwDoBAAAAFWCJCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQFfOwAuAERfOwAAAAf/////AQH/////AAAAAARggAoBAAAAAQAQ" +
           "AAAAU3VzcGVuZGVkVG9SZWFkeQEBYDsALwEABglgOwAAAwAAAAAzAAEBTTsANAABAUM7ADYAAQHAOgEA" +
           "AAAVYIkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAWE7AC4ARGE7AAAAB/////8BAf////8AAAAA" +
           "BGCACgEAAAABAA0AAABSZWFkeVRvSGFsdGVkAQFiOwAvAQAGCWI7AAADAAAAADMAAQFDOwA0AAEBSDsA" +
           "NgABAcA6AQAAABVgiQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBYzsALgBEYzsAAAAH/////wEB" +
           "/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Identifier
        {
            get
            {
                return m_identifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_identifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identifier = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> IsInstantiable
        {
            get
            {
                return m_isInstantiable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isInstantiable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isInstantiable = value;
            }
        }

        /// <remarks />
        public BaseObjectState Functionality
        {
            get
            {
                return m_functionality;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionality, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionality = value;
            }
        }

        /// <remarks />
        public SkillStateMachineState StateMachine
        {
            get
            {
                return m_stateMachine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stateMachine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stateMachine = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_identifier != null)
            {
                children.Add(m_identifier);
            }

            if (m_isInstantiable != null)
            {
                children.Add(m_isInstantiable);
            }

            if (m_functionality != null)
            {
                children.Add(m_functionality);
            }

            if (m_stateMachine != null)
            {
                children.Add(m_stateMachine);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.Skills.BrowseNames.Identifier:
                {
                    if (createOrReplace)
                    {
                        if (Identifier == null)
                        {
                            if (replacement == null)
                            {
                                Identifier = new PropertyState<string>(this);
                            }
                            else
                            {
                                Identifier = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Identifier;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.IsInstantiable:
                {
                    if (createOrReplace)
                    {
                        if (IsInstantiable == null)
                        {
                            if (replacement == null)
                            {
                                IsInstantiable = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsInstantiable = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsInstantiable;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.Functionality:
                {
                    if (createOrReplace)
                    {
                        if (Functionality == null)
                        {
                            if (replacement == null)
                            {
                                Functionality = new BaseObjectState(this);
                            }
                            else
                            {
                                Functionality = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Functionality;
                    break;
                }

                case Opc.Ua.Skills.BrowseNames.StateMachine:
                {
                    if (createOrReplace)
                    {
                        if (StateMachine == null)
                        {
                            if (replacement == null)
                            {
                                StateMachine = new SkillStateMachineState(this);
                            }
                            else
                            {
                                StateMachine = (SkillStateMachineState)replacement;
                            }
                        }
                    }

                    instance = StateMachine;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_identifier;
        private PropertyState<bool> m_isInstantiable;
        private BaseObjectState m_functionality;
        private SkillStateMachineState m_stateMachine;
        #endregion
    }
    #endif
    #endregion
}