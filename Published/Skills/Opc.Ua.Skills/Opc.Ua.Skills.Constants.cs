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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Opc.Ua.Skills
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Open = 15015;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Close = 15018;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Read = 15020;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Write = 15023;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_GetPosition = 15025;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_SetPosition = 15028;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Start Method.
        /// </summary>
        public const uint SkillStateMachineType_Start = 15080;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halt Method.
        /// </summary>
        public const uint SkillStateMachineType_Halt = 15083;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Reset Method.
        /// </summary>
        public const uint SkillStateMachineType_Reset = 15086;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Resume Method.
        /// </summary>
        public const uint SkillStateMachineType_Resume = 15089;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspend Method.
        /// </summary>
        public const uint SkillStateMachineType_Suspend = 15092;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata Object.
        /// </summary>
        public const uint SkillsNamespaceMetadata = 15001;

        /// <summary>
        /// The identifier for the SkillStateType_ContinuousParameter Object.
        /// </summary>
        public const uint SkillStateType_ContinuousParameter = 15037;

        /// <summary>
        /// The identifier for the SkillStateType_ContinuousParameter_InputParameter Object.
        /// </summary>
        public const uint SkillStateType_ContinuousParameter_InputParameter = 15038;

        /// <summary>
        /// The identifier for the SkillStateType_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public const uint SkillStateType_ContinuousParameter_OutputParameter = 15039;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Running Object.
        /// </summary>
        public const uint SkillStateMachineType_Running = 15095;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Ready Object.
        /// </summary>
        public const uint SkillStateMachineType_Ready = 15100;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halted Object.
        /// </summary>
        public const uint SkillStateMachineType_Halted = 15105;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspended Object.
        /// </summary>
        public const uint SkillStateMachineType_Suspended = 15110;

        /// <summary>
        /// The identifier for the SkillStateMachineType_HaltedToReady Object.
        /// </summary>
        public const uint SkillStateMachineType_HaltedToReady = 15115;

        /// <summary>
        /// The identifier for the SkillStateMachineType_ReadyToRunning Object.
        /// </summary>
        public const uint SkillStateMachineType_ReadyToRunning = 15117;

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToHalted Object.
        /// </summary>
        public const uint SkillStateMachineType_RunningToHalted = 15119;

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToReady Object.
        /// </summary>
        public const uint SkillStateMachineType_RunningToReady = 15121;

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToSuspended Object.
        /// </summary>
        public const uint SkillStateMachineType_RunningToSuspended = 15123;

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToRunning Object.
        /// </summary>
        public const uint SkillStateMachineType_SuspendedToRunning = 15125;

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToHalted Object.
        /// </summary>
        public const uint SkillStateMachineType_SuspendedToHalted = 15127;

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToReady Object.
        /// </summary>
        public const uint SkillStateMachineType_SuspendedToReady = 15129;

        /// <summary>
        /// The identifier for the SkillStateMachineType_ReadyToHalted Object.
        /// </summary>
        public const uint SkillStateMachineType_ReadyToHalted = 15131;

        /// <summary>
        /// The identifier for the SkillType_Functionality Object.
        /// </summary>
        public const uint SkillType_Functionality = 15136;

        /// <summary>
        /// The identifier for the SkillType_StateMachine Object.
        /// </summary>
        public const uint SkillType_StateMachine = 15137;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Running Object.
        /// </summary>
        public const uint SkillType_StateMachine_Running = 15166;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Ready Object.
        /// </summary>
        public const uint SkillType_StateMachine_Ready = 15171;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Halted Object.
        /// </summary>
        public const uint SkillType_StateMachine_Halted = 15176;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Suspended Object.
        /// </summary>
        public const uint SkillType_StateMachine_Suspended = 15181;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint SkillType_StateMachine_HaltedToReady = 15186;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint SkillType_StateMachine_ReadyToRunning = 15188;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint SkillType_StateMachine_RunningToHalted = 15190;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint SkillType_StateMachine_RunningToReady = 15192;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint SkillType_StateMachine_RunningToSuspended = 15194;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint SkillType_StateMachine_SuspendedToRunning = 15196;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint SkillType_StateMachine_SuspendedToHalted = 15198;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint SkillType_StateMachine_SuspendedToReady = 15200;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint SkillType_StateMachine_ReadyToHalted = 15202;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the SkillStateType ObjectType.
        /// </summary>
        public const uint SkillStateType = 15035;

        /// <summary>
        /// The identifier for the SkillStateTransitionEventType ObjectType.
        /// </summary>
        public const uint SkillStateTransitionEventType = 15040;

        /// <summary>
        /// The identifier for the SkillStateMachineType ObjectType.
        /// </summary>
        public const uint SkillStateMachineType = 15066;

        /// <summary>
        /// The identifier for the SkillType ObjectType.
        /// </summary>
        public const uint SkillType = 15133;
    }
    #endregion

    #region ReferenceType Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypes
    {
        /// <summary>
        /// The identifier for the UsesSkill ReferenceType.
        /// </summary>
        public const uint UsesSkill = 15204;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceUri = 15002;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceVersion = 15003;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespacePublicationDate = 15004;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_IsNamespaceSubset = 15005;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_StaticNodeIdTypes = 15006;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_StaticNumericNodeIdRange = 15007;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_StaticStringNodeIdPattern = 15008;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Size = 15010;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Writable = 15011;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_UserWritable = 15012;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_OpenCount = 15013;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Open_InputArguments = 15016;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Open_OutputArguments = 15017;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Close_InputArguments = 15019;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Read_InputArguments = 15021;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Read_OutputArguments = 15022;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_Write_InputArguments = 15024;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = 15026;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = 15027;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = 15029;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_DefaultRolePermissions = 15031;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_DefaultUserRolePermissions = 15032;

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public const uint SkillsNamespaceMetadata_DefaultAccessRestrictions = 15033;

        /// <summary>
        /// The identifier for the SkillStateTransitionEventType_Transition_Id Variable.
        /// </summary>
        public const uint SkillStateTransitionEventType_Transition_Id = 15051;

        /// <summary>
        /// The identifier for the SkillStateTransitionEventType_FromState_Id Variable.
        /// </summary>
        public const uint SkillStateTransitionEventType_FromState_Id = 15057;

        /// <summary>
        /// The identifier for the SkillStateTransitionEventType_ToState_Id Variable.
        /// </summary>
        public const uint SkillStateTransitionEventType_ToState_Id = 15062;

        /// <summary>
        /// The identifier for the SkillStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public const uint SkillStateMachineType_CurrentState_Id = 15068;

        /// <summary>
        /// The identifier for the SkillStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public const uint SkillStateMachineType_LastTransition_Id = 15073;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Start_InputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Start_InputArguments = 15081;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Start_OutputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Start_OutputArguments = 15082;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halt_InputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Halt_InputArguments = 15084;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halt_OutputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Halt_OutputArguments = 15085;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Reset_InputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Reset_InputArguments = 15087;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Reset_OutputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Reset_OutputArguments = 15088;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Resume_InputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Resume_InputArguments = 15090;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Resume_OutputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Resume_OutputArguments = 15091;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspend_InputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Suspend_InputArguments = 15093;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspend_OutputArguments Variable.
        /// </summary>
        public const uint SkillStateMachineType_Suspend_OutputArguments = 15094;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Running_StateNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_Running_StateNumber = 15096;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Ready_StateNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_Ready_StateNumber = 15101;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halted_StateNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_Halted_StateNumber = 15106;

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_Suspended_StateNumber = 15111;

        /// <summary>
        /// The identifier for the SkillStateMachineType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_HaltedToReady_TransitionNumber = 15116;

        /// <summary>
        /// The identifier for the SkillStateMachineType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_ReadyToRunning_TransitionNumber = 15118;

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_RunningToHalted_TransitionNumber = 15120;

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_RunningToReady_TransitionNumber = 15122;

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_RunningToSuspended_TransitionNumber = 15124;

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_SuspendedToRunning_TransitionNumber = 15126;

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_SuspendedToHalted_TransitionNumber = 15128;

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_SuspendedToReady_TransitionNumber = 15130;

        /// <summary>
        /// The identifier for the SkillStateMachineType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillStateMachineType_ReadyToHalted_TransitionNumber = 15132;

        /// <summary>
        /// The identifier for the SkillType_Identifier Variable.
        /// </summary>
        public const uint SkillType_Identifier = 15134;

        /// <summary>
        /// The identifier for the SkillType_IsInstantiable Variable.
        /// </summary>
        public const uint SkillType_IsInstantiable = 15135;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint SkillType_StateMachine_CurrentState = 15138;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint SkillType_StateMachine_CurrentState_Id = 15139;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint SkillType_StateMachine_LastTransition_Id = 15144;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_Running_StateNumber = 15167;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_Ready_StateNumber = 15172;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_Halted_StateNumber = 15177;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_Suspended_StateNumber = 15182;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_HaltedToReady_TransitionNumber = 15187;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_ReadyToRunning_TransitionNumber = 15189;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_RunningToHalted_TransitionNumber = 15191;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_RunningToReady_TransitionNumber = 15193;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_RunningToSuspended_TransitionNumber = 15195;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_SuspendedToRunning_TransitionNumber = 15197;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_SuspendedToHalted_TransitionNumber = 15199;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_SuspendedToReady_TransitionNumber = 15201;

        /// <summary>
        /// The identifier for the SkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint SkillType_StateMachine_ReadyToHalted_TransitionNumber = 15203;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Open = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillsNamespaceMetadata_NamespaceFile_Open, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Close = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillsNamespaceMetadata_NamespaceFile_Close, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Read = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillsNamespaceMetadata_NamespaceFile_Read, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Write = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillsNamespaceMetadata_NamespaceFile_Write, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_GetPosition = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillsNamespaceMetadata_NamespaceFile_GetPosition, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_SetPosition = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillsNamespaceMetadata_NamespaceFile_SetPosition, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Start = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillStateMachineType_Start, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Halt = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillStateMachineType_Halt, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Reset = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillStateMachineType_Reset, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Resume = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillStateMachineType_Resume, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Suspend = new ExpandedNodeId(Opc.Ua.Skills.Methods.SkillStateMachineType_Suspend, Opc.Ua.Skills.Namespaces.OpcUaSkills);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillsNamespaceMetadata, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateType_ContinuousParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateType_ContinuousParameter = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateType_ContinuousParameter, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateType_ContinuousParameter_InputParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateType_ContinuousParameter_InputParameter = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateType_ContinuousParameter_InputParameter, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateType_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateType_ContinuousParameter_OutputParameter = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateType_ContinuousParameter_OutputParameter, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Running = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_Running, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Ready = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_Ready, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Halted = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_Halted, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Suspended = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_Suspended, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_HaltedToReady = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_HaltedToReady, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_ReadyToRunning = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_ReadyToRunning, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_RunningToHalted = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_RunningToHalted, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_RunningToReady = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_RunningToReady, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_RunningToSuspended = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_RunningToSuspended, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_SuspendedToRunning = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_SuspendedToRunning, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_SuspendedToHalted = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_SuspendedToHalted, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_SuspendedToReady = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_SuspendedToReady, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_ReadyToHalted = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillStateMachineType_ReadyToHalted, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_Functionality Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Functionality = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_Functionality, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_Running = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_Running, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_Ready = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_Ready, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_Halted = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_Halted, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_Suspended = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_Suspended, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_HaltedToReady = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_HaltedToReady, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_ReadyToRunning = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_ReadyToRunning, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_RunningToHalted = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_RunningToHalted, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_RunningToReady = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_RunningToReady, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_RunningToSuspended = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_RunningToSuspended, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_SuspendedToRunning = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_SuspendedToRunning, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_SuspendedToHalted = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_SuspendedToHalted, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_SuspendedToReady = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_SuspendedToReady, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_ReadyToHalted = new ExpandedNodeId(Opc.Ua.Skills.Objects.SkillType_StateMachine_ReadyToHalted, Opc.Ua.Skills.Namespaces.OpcUaSkills);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the SkillStateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateType = new ExpandedNodeId(Opc.Ua.Skills.ObjectTypes.SkillStateType, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateTransitionEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateTransitionEventType = new ExpandedNodeId(Opc.Ua.Skills.ObjectTypes.SkillStateTransitionEventType, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType = new ExpandedNodeId(Opc.Ua.Skills.ObjectTypes.SkillStateMachineType, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SkillType = new ExpandedNodeId(Opc.Ua.Skills.ObjectTypes.SkillType, Opc.Ua.Skills.Namespaces.OpcUaSkills);
    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypeIds
    {
        /// <summary>
        /// The identifier for the UsesSkill ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId UsesSkill = new ExpandedNodeId(Opc.Ua.Skills.ReferenceTypes.UsesSkill, Opc.Ua.Skills.Namespaces.OpcUaSkills);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceUri = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceUri, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceVersion = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceVersion, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespacePublicationDate = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespacePublicationDate, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_IsNamespaceSubset = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_IsNamespaceSubset, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_StaticNodeIdTypes = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_StaticNodeIdTypes, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_StaticNumericNodeIdRange = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_StaticNumericNodeIdRange, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_StaticStringNodeIdPattern = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_StaticStringNodeIdPattern, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Size = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_Size, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Writable = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_Writable, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_UserWritable = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_UserWritable, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_OpenCount = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_OpenCount, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Open_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_Open_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Open_OutputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_Open_OutputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Close_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_Close_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Read_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_Read_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Read_OutputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_Read_OutputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_Write_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_Write_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_GetPosition_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_NamespaceFile_SetPosition_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_DefaultRolePermissions = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_DefaultRolePermissions, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_DefaultUserRolePermissions = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_DefaultUserRolePermissions, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillsNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillsNamespaceMetadata_DefaultAccessRestrictions = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillsNamespaceMetadata_DefaultAccessRestrictions, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateTransitionEventType_Transition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateTransitionEventType_Transition_Id = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateTransitionEventType_Transition_Id, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateTransitionEventType_FromState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateTransitionEventType_FromState_Id = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateTransitionEventType_FromState_Id, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateTransitionEventType_ToState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateTransitionEventType_ToState_Id = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateTransitionEventType_ToState_Id, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_CurrentState_Id, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_LastTransition_Id, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Start_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Start_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Start_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Start_OutputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Start_OutputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halt_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Halt_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Halt_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halt_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Halt_OutputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Halt_OutputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Reset_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Reset_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Reset_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Reset_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Reset_OutputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Reset_OutputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Resume_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Resume_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Resume_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Resume_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Resume_OutputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Resume_OutputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspend_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Suspend_InputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Suspend_InputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspend_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Suspend_OutputArguments = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Suspend_OutputArguments, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Running_StateNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Running_StateNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Ready_StateNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Ready_StateNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Halted_StateNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Halted_StateNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_Suspended_StateNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_Suspended_StateNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_HaltedToReady_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_HaltedToReady_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_ReadyToRunning_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_RunningToHalted_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_RunningToHalted_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_RunningToReady_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_RunningToReady_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_RunningToSuspended_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_SuspendedToRunning_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_SuspendedToHalted_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_SuspendedToReady_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillStateMachineType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillStateMachineType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillStateMachineType_ReadyToHalted_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_Identifier = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_Identifier, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_IsInstantiable = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_IsInstantiable, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_CurrentState, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_CurrentState_Id, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_LastTransition_Id, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_Running_StateNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_Running_StateNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_Ready_StateNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_Ready_StateNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_Halted_StateNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_Halted_StateNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_Suspended_StateNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_HaltedToReady_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_ReadyToRunning_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_RunningToHalted_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_RunningToReady_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_RunningToSuspended_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_SuspendedToRunning_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_SuspendedToHalted_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_SuspendedToReady_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);

        /// <summary>
        /// The identifier for the SkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId SkillType_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Opc.Ua.Skills.Variables.SkillType_StateMachine_ReadyToHalted_TransitionNumber, Opc.Ua.Skills.Namespaces.OpcUaSkills);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the ContinuousParameter component.
        /// </summary>
        public const string ContinuousParameter = "ContinuousParameter";

        /// <summary>
        /// The BrowseName for the Functionality component.
        /// </summary>
        public const string Functionality = "Functionality";

        /// <summary>
        /// The BrowseName for the Halt component.
        /// </summary>
        public const string Halt = "Halt";

        /// <summary>
        /// The BrowseName for the Halted component.
        /// </summary>
        public const string Halted = "Halted";

        /// <summary>
        /// The BrowseName for the HaltedToReady component.
        /// </summary>
        public const string HaltedToReady = "HaltedToReady";

        /// <summary>
        /// The BrowseName for the Identifier component.
        /// </summary>
        public const string Identifier = "Identifier";

        /// <summary>
        /// The BrowseName for the IsInstantiable component.
        /// </summary>
        public const string IsInstantiable = "IsInstantiable";

        /// <summary>
        /// The BrowseName for the Ready component.
        /// </summary>
        public const string Ready = "Ready";

        /// <summary>
        /// The BrowseName for the ReadyToHalted component.
        /// </summary>
        public const string ReadyToHalted = "ReadyToHalted";

        /// <summary>
        /// The BrowseName for the ReadyToRunning component.
        /// </summary>
        public const string ReadyToRunning = "ReadyToRunning";

        /// <summary>
        /// The BrowseName for the Reset component.
        /// </summary>
        public const string Reset = "Reset";

        /// <summary>
        /// The BrowseName for the Resume component.
        /// </summary>
        public const string Resume = "Resume";

        /// <summary>
        /// The BrowseName for the Running component.
        /// </summary>
        public const string Running = "Running";

        /// <summary>
        /// The BrowseName for the RunningToHalted component.
        /// </summary>
        public const string RunningToHalted = "RunningToHalted";

        /// <summary>
        /// The BrowseName for the RunningToReady component.
        /// </summary>
        public const string RunningToReady = "RunningToReady";

        /// <summary>
        /// The BrowseName for the RunningToSuspended component.
        /// </summary>
        public const string RunningToSuspended = "RunningToSuspended";

        /// <summary>
        /// The BrowseName for the SkillsNamespaceMetadata component.
        /// </summary>
        public const string SkillsNamespaceMetadata = "http://opcfoundation.org/UA/Skills/";

        /// <summary>
        /// The BrowseName for the SkillStateMachineType component.
        /// </summary>
        public const string SkillStateMachineType = "SkillStateMachineType";

        /// <summary>
        /// The BrowseName for the SkillStateTransitionEventType component.
        /// </summary>
        public const string SkillStateTransitionEventType = "SkillStateTransitionEventType";

        /// <summary>
        /// The BrowseName for the SkillStateType component.
        /// </summary>
        public const string SkillStateType = "SkillStateType";

        /// <summary>
        /// The BrowseName for the SkillType component.
        /// </summary>
        public const string SkillType = "SkillType";

        /// <summary>
        /// The BrowseName for the Start component.
        /// </summary>
        public const string Start = "Start";

        /// <summary>
        /// The BrowseName for the StateMachine component.
        /// </summary>
        public const string StateMachine = "StateMachine";

        /// <summary>
        /// The BrowseName for the Suspend component.
        /// </summary>
        public const string Suspend = "Suspend";

        /// <summary>
        /// The BrowseName for the Suspended component.
        /// </summary>
        public const string Suspended = "Suspended";

        /// <summary>
        /// The BrowseName for the SuspendedToHalted component.
        /// </summary>
        public const string SuspendedToHalted = "SuspendedToHalted";

        /// <summary>
        /// The BrowseName for the SuspendedToReady component.
        /// </summary>
        public const string SuspendedToReady = "SuspendedToReady";

        /// <summary>
        /// The BrowseName for the SuspendedToRunning component.
        /// </summary>
        public const string SuspendedToRunning = "SuspendedToRunning";

        /// <summary>
        /// The BrowseName for the UsesSkill component.
        /// </summary>
        public const string UsesSkill = "UsesSkill";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaSkills namespace (.NET code namespace is 'Opc.Ua.Skills').
        /// </summary>
        public const string OpcUaSkills = "http://opcfoundation.org/UA/Skills/";

        /// <summary>
        /// The URI for the OpcUaSkillsXsd namespace (.NET code namespace is 'Opc.Ua.Skills').
        /// </summary>
        public const string OpcUaSkillsXsd = "http://opcfoundation.org/UA/Skills/Types.xsd";
    }
    #endregion
}