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
using Opc.Ua.Skills;
using Opc.Ua.Di;

namespace Example.LinearAxisWithGripper
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
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open = 15015;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close = 15018;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read = 15020;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write = 15023;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition = 15025;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition = 15028;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Start Method.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Start = 15054;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Halt Method.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Halt = 15057;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Reset Method.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Reset = 15060;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Resume Method.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Resume = 15063;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Suspend Method.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Suspend = 15066;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Start Method.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Start = 15128;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Halt Method.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Halt = 15131;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Reset Method.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Reset = 15134;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Resume Method.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Resume = 15137;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Suspend Method.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Suspend = 15140;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Start Method.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Start = 15201;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Halt Method.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Halt = 15204;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Reset Method.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Reset = 15207;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Resume Method.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Resume = 15210;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Suspend Method.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Suspend = 15213;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Start Method.
        /// </summary>
        public const uint PickSkillType_StateMachine_Start = 15275;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Halt Method.
        /// </summary>
        public const uint PickSkillType_StateMachine_Halt = 15278;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Reset Method.
        /// </summary>
        public const uint PickSkillType_StateMachine_Reset = 15281;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Resume Method.
        /// </summary>
        public const uint PickSkillType_StateMachine_Resume = 15284;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Suspend Method.
        /// </summary>
        public const uint PickSkillType_StateMachine_Suspend = 15287;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_InitLock Method.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_InitLock = 15342;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_RenewLock Method.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_RenewLock = 15345;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_ExitLock Method.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_ExitLock = 15347;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_BreakLock Method.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_BreakLock = 15349;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_InitLock = 15377;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_RenewLock = 15380;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_ExitLock = 15382;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_BreakLock = 15384;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_InitLock Method.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_InitLock = 15412;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_RenewLock Method.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_RenewLock = 15415;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_ExitLock Method.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_ExitLock = 15417;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_BreakLock Method.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_BreakLock = 15419;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_InitLock = 15447;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_RenewLock = 15450;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_ExitLock = 15452;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_BreakLock = 15454;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start = 15487;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halt Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halt = 15490;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Reset Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Reset = 15493;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Resume Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Resume = 15496;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspend Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspend = 15499;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start = 15558;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halt Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halt = 15561;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Reset Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Reset = 15564;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Resume Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Resume = 15567;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspend Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspend = 15570;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start = 15630;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halt Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halt = 15633;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Reset Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Reset = 15636;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Resume Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Resume = 15639;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspend Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspend = 15642;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Start Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Start = 15702;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Halt Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Halt = 15705;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Reset Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Reset = 15708;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Resume Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Resume = 15711;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspend Method.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspend = 15714;
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
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata Object.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata = 15001;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine = 15040;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Running = 15069;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Running_ContinuousParameter = 15071;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter = 15073;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Ready Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Ready = 15074;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Halted Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Halted = 15079;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Suspended Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Suspended = 15084;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_HaltedToReady = 15089;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_ReadyToRunning = 15091;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_RunningToHalted = 15093;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_RunningToReady = 15095;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_RunningToSuspended = 15097;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_SuspendedToRunning = 15099;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_SuspendedToHalted = 15101;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_SuspendedToReady = 15103;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint GraspSkillType_StateMachine_ReadyToHalted = 15105;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine = 15114;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Running Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Running = 15143;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Ready Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Ready = 15148;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Halted Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Halted = 15153;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Suspended Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Suspended = 15158;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_HaltedToReady = 15163;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_ReadyToRunning = 15165;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_RunningToHalted = 15167;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_RunningToReady = 15169;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_RunningToSuspended = 15171;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_SuspendedToRunning = 15173;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_SuspendedToHalted = 15175;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_SuspendedToReady = 15177;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_ReadyToHalted = 15179;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine = 15187;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Running = 15216;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter = 15218;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter = 15220;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Ready Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Ready = 15221;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Halted Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Halted = 15226;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Suspended Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Suspended = 15231;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_HaltedToReady = 15236;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_ReadyToRunning = 15238;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_RunningToHalted = 15240;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_RunningToReady = 15242;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_RunningToSuspended = 15244;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_SuspendedToRunning = 15246;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_SuspendedToHalted = 15248;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_SuspendedToReady = 15250;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_ReadyToHalted = 15252;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine Object.
        /// </summary>
        public const uint PickSkillType_StateMachine = 15261;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Running Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_Running = 15290;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Ready Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_Ready = 15295;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Halted Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_Halted = 15300;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Suspended Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_Suspended = 15305;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_HaltedToReady = 15310;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_ReadyToRunning = 15312;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_RunningToHalted = 15314;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_RunningToReady = 15316;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_RunningToSuspended = 15318;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_SuspendedToRunning = 15320;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_SuspendedToHalted = 15322;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_SuspendedToReady = 15324;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint PickSkillType_StateMachine_ReadyToHalted = 15326;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_NetworkAddress = 15386;

        /// <summary>
        /// The identifier for the LinAxisWithGripper Object.
        /// </summary>
        public const uint LinAxisWithGripper = 15398;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_NetworkAddress = 15456;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills = 15468;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill = 15469;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine = 15473;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running = 15502;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready = 15507;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted = 15512;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended = 15517;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady = 15522;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning = 15524;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted = 15526;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady = 15528;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended = 15530;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning = 15532;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted = 15534;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady = 15536;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted = 15538;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill = 15540;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine = 15544;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running = 15573;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter = 15577;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready = 15578;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted = 15583;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended = 15588;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady = 15593;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning = 15595;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted = 15597;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady = 15599;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended = 15601;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning = 15603;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted = 15605;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady = 15607;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted = 15609;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill = 15612;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine = 15616;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running = 15645;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter = 15647;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter = 15649;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready = 15650;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted = 15655;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended = 15660;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady = 15665;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning = 15667;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted = 15669;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady = 15671;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended = 15673;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning = 15675;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted = 15677;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady = 15679;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted = 15681;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill = 15684;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine = 15688;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Running Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Running = 15717;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready = 15722;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted = 15727;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended = 15732;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady = 15737;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning = 15739;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted = 15741;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady = 15743;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended = 15745;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning = 15747;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted = 15749;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady = 15751;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted Object.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted = 15753;
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
        /// The identifier for the GraspSkillType ObjectType.
        /// </summary>
        public const uint GraspSkillType = 15036;

        /// <summary>
        /// The identifier for the ReleaseSkillType ObjectType.
        /// </summary>
        public const uint ReleaseSkillType = 15110;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType ObjectType.
        /// </summary>
        public const uint MoveToAbsPosSkillType = 15183;

        /// <summary>
        /// The identifier for the PickSkillType ObjectType.
        /// </summary>
        public const uint PickSkillType = 15257;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType ObjectType.
        /// </summary>
        public const uint LinAxisWithGripperType = 15328;
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
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri = 15002;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion = 15003;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate = 15004;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset = 15005;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes = 15006;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange = 15007;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern = 15008;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size = 15010;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable = 15011;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable = 15012;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount = 15013;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments = 15016;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments = 15017;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments = 15019;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments = 15021;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments = 15022;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments = 15024;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = 15026;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = 15027;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = 15029;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions = 15031;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions = 15032;

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public const uint ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions = 15033;

        /// <summary>
        /// The identifier for the GraspSkillType_Identifier Variable.
        /// </summary>
        public const uint GraspSkillType_Identifier = 15037;

        /// <summary>
        /// The identifier for the GraspSkillType_IsInstantiable Variable.
        /// </summary>
        public const uint GraspSkillType_IsInstantiable = 15038;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_CurrentState = 15041;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_CurrentState_Id = 15042;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_LastTransition Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_LastTransition = 15046;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_LastTransition_Id = 15047;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_LastTransition_TransitionTime = 15050;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Start_InputArguments = 15055;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Start_OutputArguments Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Start_OutputArguments = 15056;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Running_StateNumber = 15070;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Ready_StateNumber = 15075;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Halted_StateNumber = 15080;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Suspended_StateNumber = 15085;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_HaltedToReady_TransitionNumber = 15090;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_ReadyToRunning_TransitionNumber = 15092;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_RunningToHalted_TransitionNumber = 15094;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_RunningToReady_TransitionNumber = 15096;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_RunningToSuspended_TransitionNumber = 15098;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_SuspendedToRunning_TransitionNumber = 15100;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_SuspendedToHalted_TransitionNumber = 15102;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_SuspendedToReady_TransitionNumber = 15104;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_ReadyToHalted_TransitionNumber = 15106;

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce Variable.
        /// </summary>
        public const uint GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce = 15107;

        /// <summary>
        /// The identifier for the ReleaseSkillType_Identifier Variable.
        /// </summary>
        public const uint ReleaseSkillType_Identifier = 15111;

        /// <summary>
        /// The identifier for the ReleaseSkillType_IsInstantiable Variable.
        /// </summary>
        public const uint ReleaseSkillType_IsInstantiable = 15112;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_CurrentState = 15115;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_CurrentState_Id = 15116;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_LastTransition Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_LastTransition = 15120;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_LastTransition_Id = 15121;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_LastTransition_TransitionTime = 15124;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Start_InputArguments = 15129;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Start_OutputArguments Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Start_OutputArguments = 15130;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Running_StateNumber = 15144;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Ready_StateNumber = 15149;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Halted_StateNumber = 15154;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_Suspended_StateNumber = 15159;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_HaltedToReady_TransitionNumber = 15164;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_ReadyToRunning_TransitionNumber = 15166;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_RunningToHalted_TransitionNumber = 15168;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_RunningToReady_TransitionNumber = 15170;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_RunningToSuspended_TransitionNumber = 15172;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_SuspendedToRunning_TransitionNumber = 15174;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_SuspendedToHalted_TransitionNumber = 15176;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_SuspendedToReady_TransitionNumber = 15178;

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint ReleaseSkillType_StateMachine_ReadyToHalted_TransitionNumber = 15180;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_Identifier Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_Identifier = 15184;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_IsInstantiable Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_IsInstantiable = 15185;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_CurrentState = 15188;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_CurrentState_Id = 15189;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_LastTransition Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_LastTransition = 15193;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_LastTransition_Id = 15194;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_LastTransition_TransitionTime = 15197;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Start_InputArguments = 15202;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Running_StateNumber = 15217;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Ready_StateNumber = 15222;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Halted_StateNumber = 15227;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Suspended_StateNumber = 15232;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_HaltedToReady_TransitionNumber = 15237;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_ReadyToRunning_TransitionNumber = 15239;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_RunningToHalted_TransitionNumber = 15241;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_RunningToReady_TransitionNumber = 15243;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_RunningToSuspended_TransitionNumber = 15245;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_SuspendedToRunning_TransitionNumber = 15247;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_SuspendedToHalted_TransitionNumber = 15249;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_SuspendedToReady_TransitionNumber = 15251;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_ReadyToHalted_TransitionNumber = 15253;

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition Variable.
        /// </summary>
        public const uint MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition = 15254;

        /// <summary>
        /// The identifier for the PickSkillType_Identifier Variable.
        /// </summary>
        public const uint PickSkillType_Identifier = 15258;

        /// <summary>
        /// The identifier for the PickSkillType_IsInstantiable Variable.
        /// </summary>
        public const uint PickSkillType_IsInstantiable = 15259;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_CurrentState = 15262;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_CurrentState_Id = 15263;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_LastTransition Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_LastTransition = 15267;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_LastTransition_Id = 15268;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_LastTransition_TransitionTime = 15271;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_Start_InputArguments = 15276;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_Running_StateNumber = 15291;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_Ready_StateNumber = 15296;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_Halted_StateNumber = 15301;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_Suspended_StateNumber = 15306;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_HaltedToReady_TransitionNumber = 15311;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_ReadyToRunning_TransitionNumber = 15313;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_RunningToHalted_TransitionNumber = 15315;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_RunningToReady_TransitionNumber = 15317;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_RunningToSuspended_TransitionNumber = 15319;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_SuspendedToRunning_TransitionNumber = 15321;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_SuspendedToHalted_TransitionNumber = 15323;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_SuspendedToReady_TransitionNumber = 15325;

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint PickSkillType_StateMachine_ReadyToHalted_TransitionNumber = 15327;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_Locked Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_Locked = 15338;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_LockingClient Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_LockingClient = 15339;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_LockingUser Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_LockingUser = 15340;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_RemainingLockTime = 15341;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_InitLock_InputArguments = 15343;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_InitLock_OutputArguments = 15344;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_RenewLock_OutputArguments = 15346;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_ExitLock_OutputArguments = 15348;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_Lock_BreakLock_OutputArguments = 15350;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_Locked = 15373;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_LockingClient = 15374;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_LockingUser = 15375;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_RemainingLockTime = 15376;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_InitLock_InputArguments = 15378;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_InitLock_OutputArguments = 15379;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_RenewLock_OutputArguments = 15381;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_ExitLock_OutputArguments = 15383;

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripperType_CPIdentifier_Lock_BreakLock_OutputArguments = 15385;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_Locked Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_Locked = 15408;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_LockingClient Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_LockingClient = 15409;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_LockingUser Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_LockingUser = 15410;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_RemainingLockTime = 15411;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_InitLock_InputArguments = 15413;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_InitLock_OutputArguments = 15414;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_RenewLock_OutputArguments = 15416;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_ExitLock_OutputArguments = 15418;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Lock_BreakLock_OutputArguments = 15420;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Manufacturer Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Manufacturer = 15421;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Model Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Model = 15423;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_HardwareRevision Variable.
        /// </summary>
        public const uint LinAxisWithGripper_HardwareRevision = 15424;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_SoftwareRevision Variable.
        /// </summary>
        public const uint LinAxisWithGripper_SoftwareRevision = 15425;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_DeviceRevision Variable.
        /// </summary>
        public const uint LinAxisWithGripper_DeviceRevision = 15426;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_DeviceManual Variable.
        /// </summary>
        public const uint LinAxisWithGripper_DeviceManual = 15428;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_SerialNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_SerialNumber = 15430;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_RevisionCounter Variable.
        /// </summary>
        public const uint LinAxisWithGripper_RevisionCounter = 15432;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_Locked = 15443;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_LockingClient = 15444;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_LockingUser = 15445;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_RemainingLockTime = 15446;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_InitLock_InputArguments = 15448;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_InitLock_OutputArguments = 15449;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_RenewLock_OutputArguments = 15451;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_ExitLock_OutputArguments = 15453;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_CPIdentifier_Lock_BreakLock_OutputArguments = 15455;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_Identifier Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_Identifier = 15470;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_IsInstantiable Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_IsInstantiable = 15471;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState = 15474;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState_Id = 15475;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition = 15479;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_Id = 15480;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_TransitionTime = 15483;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start_InputArguments = 15488;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running_StateNumber = 15503;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready_StateNumber = 15508;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted_StateNumber = 15513;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended_StateNumber = 15518;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady_TransitionNumber = 15523;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning_TransitionNumber = 15525;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted_TransitionNumber = 15527;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady_TransitionNumber = 15529;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended_TransitionNumber = 15531;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning_TransitionNumber = 15533;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted_TransitionNumber = 15535;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady_TransitionNumber = 15537;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted_TransitionNumber = 15539;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_Identifier Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_Identifier = 15541;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_IsInstantiable Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_IsInstantiable = 15542;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState = 15545;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState_Id = 15546;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition = 15550;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_Id = 15551;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_TransitionTime = 15554;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start_InputArguments = 15559;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_StateNumber = 15574;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready_StateNumber = 15579;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted_StateNumber = 15584;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended_StateNumber = 15589;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady_TransitionNumber = 15594;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning_TransitionNumber = 15596;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted_TransitionNumber = 15598;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady_TransitionNumber = 15600;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended_TransitionNumber = 15602;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning_TransitionNumber = 15604;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted_TransitionNumber = 15606;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady_TransitionNumber = 15608;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted_TransitionNumber = 15610;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce = 15611;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_Identifier Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_Identifier = 15613;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_IsInstantiable Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_IsInstantiable = 15614;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState = 15617;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState_Id = 15618;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition = 15622;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_Id = 15623;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_TransitionTime = 15626;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start_InputArguments = 15631;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_StateNumber = 15646;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready_StateNumber = 15651;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted_StateNumber = 15656;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended_StateNumber = 15661;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady_TransitionNumber = 15666;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning_TransitionNumber = 15668;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted_TransitionNumber = 15670;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady_TransitionNumber = 15672;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended_TransitionNumber = 15674;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning_TransitionNumber = 15676;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted_TransitionNumber = 15678;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady_TransitionNumber = 15680;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted_TransitionNumber = 15682;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition = 15683;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_Identifier Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_Identifier = 15685;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_IsInstantiable Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_IsInstantiable = 15686;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState = 15689;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState_Id = 15690;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition = 15694;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_Id = 15695;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_TransitionTime = 15698;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Start_InputArguments = 15703;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Running_StateNumber = 15718;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready_StateNumber = 15723;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted_StateNumber = 15728;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended_StateNumber = 15733;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady_TransitionNumber = 15738;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning_TransitionNumber = 15740;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted_TransitionNumber = 15742;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady_TransitionNumber = 15744;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended_TransitionNumber = 15746;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning_TransitionNumber = 15748;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted_TransitionNumber = 15750;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady_TransitionNumber = 15752;

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted_TransitionNumber = 15754;
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
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.GraspSkillType_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.GraspSkillType_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.GraspSkillType_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.GraspSkillType_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.GraspSkillType_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ReleaseSkillType_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ReleaseSkillType_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ReleaseSkillType_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ReleaseSkillType_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.ReleaseSkillType_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.MoveToAbsPosSkillType_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.MoveToAbsPosSkillType_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.MoveToAbsPosSkillType_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.MoveToAbsPosSkillType_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.MoveToAbsPosSkillType_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.PickSkillType_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.PickSkillType_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.PickSkillType_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.PickSkillType_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.PickSkillType_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_InitLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripperType_Lock_InitLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_RenewLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripperType_Lock_RenewLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_ExitLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripperType_Lock_ExitLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_BreakLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripperType_Lock_BreakLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripperType_CPIdentifier_Lock_InitLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripperType_CPIdentifier_Lock_RenewLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripperType_CPIdentifier_Lock_ExitLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripperType_CPIdentifier_Lock_BreakLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_InitLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Lock_InitLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_RenewLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Lock_RenewLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_ExitLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Lock_ExitLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_BreakLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Lock_BreakLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_CPIdentifier_Lock_InitLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_CPIdentifier_Lock_RenewLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_CPIdentifier_Lock_ExitLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_CPIdentifier_Lock_BreakLock, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Start = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_PickSkill_StateMachine_Start, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Halt Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Halt = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_PickSkill_StateMachine_Halt, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Reset = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_PickSkill_StateMachine_Reset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Resume = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_PickSkill_StateMachine_Resume, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspend = new ExpandedNodeId(Example.LinearAxisWithGripper.Methods.LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspend, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);
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
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata Object.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ExampleLinearAxisWithGripperNamespaceMetadata, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Running_ContinuousParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_Running_ContinuousParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.GraspSkillType_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.ReleaseSkillType_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.MoveToAbsPosSkillType_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.PickSkillType_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripperType_CPIdentifier_NetworkAddress, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_NetworkAddress = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_CPIdentifier_NetworkAddress, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Running Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Running = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_Running, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted Object.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted = new ExpandedNodeId(Example.LinearAxisWithGripper.Objects.LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);
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
        /// The identifier for the GraspSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType = new ExpandedNodeId(Example.LinearAxisWithGripper.ObjectTypes.GraspSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType = new ExpandedNodeId(Example.LinearAxisWithGripper.ObjectTypes.ReleaseSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType = new ExpandedNodeId(Example.LinearAxisWithGripper.ObjectTypes.MoveToAbsPosSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType = new ExpandedNodeId(Example.LinearAxisWithGripper.ObjectTypes.PickSkillType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType = new ExpandedNodeId(Example.LinearAxisWithGripper.ObjectTypes.LinAxisWithGripperType, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);
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
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceUri, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceVersion, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespacePublicationDate, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_IsNamespaceSubset, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_StaticNodeIdTypes, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_StaticNumericNodeIdRange, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_StaticStringNodeIdPattern, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Size, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Writable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_UserWritable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_OpenCount, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Open_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Close_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Read_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_Write_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_GetPosition_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_NamespaceFile_SetPosition_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_DefaultRolePermissions, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_DefaultUserRolePermissions, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public static readonly ExpandedNodeId ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ExampleLinearAxisWithGripperNamespaceMetadata_DefaultAccessRestrictions, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_LastTransition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_LastTransition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_LastTransition_TransitionTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_LastTransition_TransitionTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Start_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Start_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_Start_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce Variable.
        /// </summary>
        public static readonly ExpandedNodeId GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.GraspSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_LastTransition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_LastTransition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_LastTransition_TransitionTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_LastTransition_TransitionTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Start_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Start_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_Start_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the ReleaseSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReleaseSkillType_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.ReleaseSkillType_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_LastTransition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_LastTransition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_LastTransition_TransitionTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_LastTransition_TransitionTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.MoveToAbsPosSkillType_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_LastTransition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_LastTransition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_LastTransition_TransitionTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_LastTransition_TransitionTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the PickSkillType_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PickSkillType_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.PickSkillType_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_Locked = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_Lock_Locked, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_LockingClient = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_Lock_LockingClient, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_LockingUser = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_Lock_LockingUser, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_RemainingLockTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_Lock_RemainingLockTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_InitLock_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_Lock_InitLock_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_Lock_InitLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_Lock_RenewLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_Lock_ExitLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_Lock_BreakLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_CPIdentifier_Lock_Locked, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_CPIdentifier_Lock_LockingClient, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_CPIdentifier_Lock_LockingUser, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_CPIdentifier_Lock_RemainingLockTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_CPIdentifier_Lock_InitLock_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_CPIdentifier_Lock_InitLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_CPIdentifier_Lock_RenewLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_CPIdentifier_Lock_ExitLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripperType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripperType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripperType_CPIdentifier_Lock_BreakLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_Locked = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Lock_Locked, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_LockingClient = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Lock_LockingClient, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_LockingUser = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Lock_LockingUser, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_RemainingLockTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Lock_RemainingLockTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_InitLock_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Lock_InitLock_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_InitLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Lock_InitLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Lock_RenewLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Lock_ExitLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Lock_BreakLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Manufacturer = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Manufacturer, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Model = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Model, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_HardwareRevision = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_HardwareRevision, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_SoftwareRevision = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_SoftwareRevision, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_DeviceRevision = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_DeviceRevision, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_DeviceManual = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_DeviceManual, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_SerialNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_SerialNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_RevisionCounter = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_RevisionCounter, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_Locked = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_CPIdentifier_Lock_Locked, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_CPIdentifier_Lock_LockingClient, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_CPIdentifier_Lock_LockingUser, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_CPIdentifier_Lock_RemainingLockTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_CPIdentifier_Lock_InitLock_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_CPIdentifier_Lock_InitLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_CPIdentifier_Lock_RenewLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_CPIdentifier_Lock_ExitLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_CPIdentifier_Lock_BreakLock_OutputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_TransitionTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_LastTransition_TransitionTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_ReleaseSkill_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_TransitionTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_LastTransition_TransitionTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_GraspSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentForce, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_TransitionTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_LastTransition_TransitionTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_MoveToAbsPosSkill_StateMachine_Running_ContinuousParameter_OutputParameter_CurrentPosition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_Identifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_Identifier = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_Identifier, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_IsInstantiable Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_IsInstantiable = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_IsInstantiable, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_CurrentState_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_Id = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_Id, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_TransitionTime = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_LastTransition_TransitionTime, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Start_InputArguments = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_Start_InputArguments, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Running_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_Running_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_Ready_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_Halted_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended_StateNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_Suspended_StateNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_HaltedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_RunningToSuspended_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToRunning_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_SuspendedToReady_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);

        /// <summary>
        /// The identifier for the LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Example.LinearAxisWithGripper.Variables.LinAxisWithGripper_Skills_PickSkill_StateMachine_ReadyToHalted_TransitionNumber, Example.LinearAxisWithGripper.Namespaces.ExampleLinearAxisWithGripper);
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
        /// The BrowseName for the ExampleLinearAxisWithGripperNamespaceMetadata component.
        /// </summary>
        public const string ExampleLinearAxisWithGripperNamespaceMetadata = "https://example.com/UA/Examples/LinearAxisWithGripper/";

        /// <summary>
        /// The BrowseName for the GraspSkillType component.
        /// </summary>
        public const string GraspSkillType = "GraspSkillType";

        /// <summary>
        /// The BrowseName for the LinAxisWithGripper component.
        /// </summary>
        public const string LinAxisWithGripper = "LinAxisWithGripper";

        /// <summary>
        /// The BrowseName for the LinAxisWithGripperType component.
        /// </summary>
        public const string LinAxisWithGripperType = "LinAxisWithGripperType";

        /// <summary>
        /// The BrowseName for the MoveToAbsPosSkillType component.
        /// </summary>
        public const string MoveToAbsPosSkillType = "MoveToAbsPosSkillType";

        /// <summary>
        /// The BrowseName for the PickSkillType component.
        /// </summary>
        public const string PickSkillType = "PickSkillType";

        /// <summary>
        /// The BrowseName for the ReleaseSkillType component.
        /// </summary>
        public const string ReleaseSkillType = "ReleaseSkillType";
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
        /// The URI for the ExampleLinearAxisWithGripper namespace (.NET code namespace is 'Example.LinearAxisWithGripper').
        /// </summary>
        public const string ExampleLinearAxisWithGripper = "https://example.com/UA/Examples/LinearAxisWithGripper/";

        /// <summary>
        /// The URI for the ExampleLinearAxisWithGripperXsd namespace (.NET code namespace is 'Example.LinearAxisWithGripper').
        /// </summary>
        public const string ExampleLinearAxisWithGripperXsd = "https://example.com/UA/Examples/LinearAxisWithGripper/Types.xsd";

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

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";
    }
    #endregion
}