﻿// -----------------------------------------------------------------------------
//                                    ILGPU
//                     Copyright (c) 2016-2020 Marcel Koester
//                                www.ilgpu.net
//
// File: CLNativeMethods.cs
//
// This file is part of ILGPU and is distributed under the University of
// Illinois Open Source License. See LICENSE.txt for details
// -----------------------------------------------------------------------------

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Diagnostics.CodeAnalysis;

namespace ILGPU.Runtime.OpenCL.API
{
    public enum CLError : int
    {
        CL_SUCCESS = 0,
        CL_DEVICE_NOT_FOUND = -1,
        CL_DEVICE_NOT_AVAILABLE = -2,
        CL_COMPILER_NOT_AVAILABLE = -3,
        CL_MEM_OBJECT_ALLOCATION_FAILURE = -4,
        CL_OUT_OF_RESOURCES = -5,
        CL_OUT_OF_HOST_MEMORY = -6,
        CL_PROFILING_INFO_NOT_AVAILABLE = -7,
        CL_MEM_COPY_OVERLAP = -8,
        CL_IMAGE_FORMAT_MISMATCH = -9,
        CL_IMAGE_FORMAT_NOT_SUPPORTED = -10,
        CL_BUILD_PROGRAM_FAILURE = -11,
        CL_MAP_FAILURE = -12,
        CL_MISALIGNED_SUB_BUFFER_OFFSET = -13,
        CL_EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST = 14,
        CL_COMPILE_PROGRAM_FAILURE = -15,
        CL_LINKER_NOT_AVAILABLE = -16,
        CL_LINK_PROGRAM_FAILURE = -17,
        CL_DEVICE_PARTITION_FAILED = -18,
        CL_KERNEL_ARG_INFO_NOT_AVAILABLE = -19,

        CL_INVALID_VALUE = -30,
        CL_INVALID_DEVICE_TYPE = -31,
        CL_INVALID_PLATFORM = -32,
        CL_INVALID_DEVICE = -33,
        CL_INVALID_CONTEXT = -34,
        CL_INVALID_QUEUE_PROPERTIES = -35,
        CL_INVALID_COMMAND_QUEUE = -36,
        CL_INVALID_HOST_PTR = -37,
        CL_INVALID_MEM_OBJECT = -38,
        CL_INVALID_IMAGE_FORMAT_DESCRIPTOR = -39,
        CL_INVALID_IMAGE_SIZE = -40,
        CL_INVALID_SAMPLER = -41,
        CL_INVALID_BINARY = -42,
        CL_INVALID_BUILD_OPTIONS = -43,
        CL_INVALID_PROGRAM = -44,
        CL_INVALID_PROGRAM_EXECUTABLE = -45,
        CL_INVALID_KERNEL_NAME = -46,
        CL_INVALID_KERNEL_DEFINITION = -47,
        CL_INVALID_KERNEL = -48,
        CL_INVALID_ARG_INDEX = -49,
        CL_INVALID_ARG_VALUE = -50,
        CL_INVALID_ARG_SIZE = -51,
        CL_INVALID_KERNEL_ARGS = -52,
        CL_INVALID_WORK_DIMENSION = -53,
        CL_INVALID_WORK_GROUP_SIZE = -54,
        CL_INVALID_WORK_ITEM_SIZE = -55,
        CL_INVALID_GLOBAL_OFFSET = -56,
        CL_INVALID_EVENT_WAIT_LIST = -57,
        CL_INVALID_EVENT = -58,
        CL_INVALID_OPERATION = -59,
        CL_INVALID_GL_OBJECT = -60,
        CL_INVALID_BUFFER_SIZE = -61,
        CL_INVALID_MIP_LEVEL = -62,
        CL_INVALID_GLOBAL_WORK_SIZE = -63,
        CL_INVALID_PROPERTY = -64,
        CL_INVALID_IMAGE_DESCRIPTOR = -65,
        CL_INVALID_COMPILER_OPTIONS = -66,
        CL_INVALID_LINKER_OPTIONS = -67,
        CL_INVALID_DEVICE_PARTITION_COUNT = -68,
    }

    [SuppressMessage("Microsoft.Design", "CA1008:Enums should have zero value",
        Justification = "Interop enum")]
    public enum CLPlatformInfoType : int
    {
        CL_PLATFORM_PROFILE = 0x0900,
        CL_PLATFORM_VERSION = 0x0901,
        CL_PLATFORM_NAME = 0x0902,
        CL_PLATFORM_VENDOR = 0x0903,
        CL_PLATFORM_EXTENSIONS = 0x0904,
    }

    [SuppressMessage("Microsoft.Design", "CA1008:Enums should have zero value",
        Justification = "Interop enum")]
    public enum CLDeviceType : int
    {
        CL_DEVICE_TYPE_DEFAULT = (1 << 0),
        CL_DEVICE_TYPE_CPU = (1 << 1),
        CL_DEVICE_TYPE_GPU = (1 << 2),
        CL_DEVICE_TYPE_ACCELERATOR = (1 << 3),
        CL_DEVICE_TYPE_CUSTOM = (1 << 4),
        CL_DEVICE_TYPE_ALL = -1
    }

    [SuppressMessage("Microsoft.Design", "CA1008:Enums should have zero value",
        Justification = "Interop enum")]
    public enum CLDeviceInfoType : int
    {
        CL_DEVICE_TYPE = 0x1000,
        CL_DEVICE_VENDOR_ID = 0x1001,
        CL_DEVICE_MAX_COMPUTE_UNITS = 0x1002,
        CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS = 0x1003,
        CL_DEVICE_MAX_WORK_GROUP_SIZE = 0x1004,
        CL_DEVICE_MAX_WORK_ITEM_SIZES = 0x1005,
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR = 0x1006,
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT = 0x1007,
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT = 0x1008,
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG = 0x1009,
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT = 0x100A,
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE = 0x100B,
        CL_DEVICE_MAX_CLOCK_FREQUENCY = 0x100C,
        CL_DEVICE_ADDRESS_BITS = 0x100D,
        CL_DEVICE_MAX_READ_IMAGE_ARGS = 0x100E,
        CL_DEVICE_MAX_WRITE_IMAGE_ARGS = 0x100F,
        CL_DEVICE_MAX_MEM_ALLOC_SIZE = 0x1010,
        CL_DEVICE_IMAGE2D_MAX_WIDTH = 0x1011,
        CL_DEVICE_IMAGE2D_MAX_HEIGHT = 0x1012,
        CL_DEVICE_IMAGE3D_MAX_WIDTH = 0x1013,
        CL_DEVICE_IMAGE3D_MAX_HEIGHT = 0x1014,
        CL_DEVICE_IMAGE3D_MAX_DEPTH = 0x1015,
        CL_DEVICE_IMAGE_SUPPORT = 0x1016,
        CL_DEVICE_MAX_PARAMETER_SIZE = 0x1017,
        CL_DEVICE_MAX_SAMPLERS = 0x1018,
        CL_DEVICE_MEM_BASE_ADDR_ALIGN = 0x1019,
        CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE = 0x101A,
        CL_DEVICE_SINGLE_FP_CONFIG = 0x101B,
        CL_DEVICE_GLOBAL_MEM_CACHE_TYPE = 0x101C,
        CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE = 0x101D,
        CL_DEVICE_GLOBAL_MEM_CACHE_SIZE = 0x101E,
        CL_DEVICE_GLOBAL_MEM_SIZE = 0x101F,
        CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE = 0x1020,
        CL_DEVICE_MAX_CONSTANT_ARGS = 0x1021,
        CL_DEVICE_LOCAL_MEM_TYPE = 0x1022,
        CL_DEVICE_LOCAL_MEM_SIZE = 0x1023,
        CL_DEVICE_ERROR_CORRECTION_SUPPORT = 0x1024,
        CL_DEVICE_PROFILING_TIMER_RESOLUTION = 0x1025,
        CL_DEVICE_ENDIAN_LITTLE = 0x1026,
        CL_DEVICE_AVAILABLE = 0x1027,
        CL_DEVICE_COMPILER_AVAILABLE = 0x1028,
        CL_DEVICE_EXECUTION_CAPABILITIES = 0x1029,
        CL_DEVICE_QUEUE_ON_HOST_PROPERTIES = 0x102A,
        CL_DEVICE_NAME = 0x102B,
        CL_DEVICE_VENDOR = 0x102C,
        CL_DRIVER_VERSION = 0x102D,
        CL_DEVICE_PROFILE = 0x102E,
        CL_DEVICE_VERSION = 0x102F,
        CL_DEVICE_EXTENSIONS = 0x1030,
        CL_DEVICE_PLATFORM = 0x1031,
        CL_DEVICE_DOUBLE_FP_CONFIG = 0x1032,
        CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF = 0x1034,
        CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR = 0x1036,
        CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT = 0x1037,
        CL_DEVICE_NATIVE_VECTOR_WIDTH_INT = 0x1038,
        CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG = 0x1039,
        CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT = 0x103A,
        CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE = 0x103B,
        CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF = 0x103C,
        CL_DEVICE_OPENCL_C_VERSION = 0x103D,
        CL_DEVICE_LINKER_AVAILABLE = 0x103E,
        CL_DEVICE_BUILT_IN_KERNELS = 0x103F,
        CL_DEVICE_IMAGE_MAX_BUFFER_SIZE = 0x1040,
        CL_DEVICE_IMAGE_MAX_ARRAY_SIZE = 0x1041,
        CL_DEVICE_PARENT_DEVICE = 0x1042,
        CL_DEVICE_PARTITION_MAX_SUB_DEVICES = 0x1043,
        CL_DEVICE_PARTITION_PROPERTIES = 0x1044,
        CL_DEVICE_PARTITION_AFFINITY_DOMAIN = 0x1045,
        CL_DEVICE_PARTITION_TYPE = 0x1046,
        CL_DEVICE_REFERENCE_COUNT = 0x1047,
        CL_DEVICE_PREFERRED_INTEROP_USER_SYNC = 0x1048,
        CL_DEVICE_PRINTF_BUFFER_SIZE = 0x1049,
        CL_DEVICE_IMAGE_PITCH_ALIGNMENT = 0x104A,
        CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT = 0x104B,
        CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS = 0x104C,
        CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE = 0x104D,
        CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES = 0x104E,
        CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE = 0x104F,
        CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE = 0x1050,
        CL_DEVICE_MAX_ON_DEVICE_QUEUES = 0x1051,
        CL_DEVICE_MAX_ON_DEVICE_EVENTS = 0x1052,
        CL_DEVICE_SVM_CAPABILITIES = 0x1053,
        CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE = 0x1054,
        CL_DEVICE_MAX_PIPE_ARGS = 0x1055,
        CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS = 0x1056,
        CL_DEVICE_PIPE_MAX_PACKET_SIZE = 0x1057,
        CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT = 0x1058,
        CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT = 0x1059,
        CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT = 0x105A,

        // AMD

        CL_DEVICE_PROFILING_TIMER_OFFSET_AMD = 0x4036,
        CL_DEVICE_TOPOLOGY_AMD = 0x4037,
        CL_DEVICE_BOARD_NAME_AMD = 0x4038,
        CL_DEVICE_GLOBAL_FREE_MEMORY_AMD = 0x4039,
        CL_DEVICE_SIMD_PER_COMPUTE_UNIT_AMD = 0x4040,
        CL_DEVICE_SIMD_WIDTH_AMD = 0x4041,
        CL_DEVICE_SIMD_INSTRUCTION_WIDTH_AMD = 0x4042,
        CL_DEVICE_WAVEFRONT_WIDTH_AMD = 0x4043,
        CL_DEVICE_GLOBAL_MEM_CHANNELS_AMD = 0x4044,
        CL_DEVICE_GLOBAL_MEM_CHANNEL_BANKS_AMD = 0x4045,
        CL_DEVICE_GLOBAL_MEM_CHANNEL_BANK_WIDTH_AMD = 0x4046,
        CL_DEVICE_LOCAL_MEM_SIZE_PER_COMPUTE_UNIT_AMD = 0x4047,
        CL_DEVICE_LOCAL_MEM_BANKS_AMD = 0x4048,
        CL_DEVICE_THREAD_TRACE_SUPPORTED_AMD = 0x4049,
        CL_DEVICE_GFXIP_MAJOR_AMD = 0x404A,
        CL_DEVICE_GFXIP_MINOR_AMD = 0x404B,
        CL_DEVICE_AVAILABLE_ASYNC_QUEUES_AMD = 0x404C,

        // NVIDIA

        CL_DEVICE_COMPUTE_CAPABILITY_MAJOR_NV = 0x4000,
        CL_DEVICE_COMPUTE_CAPABILITY_MINOR_NV = 0x4001,
        CL_DEVICE_REGISTERS_PER_BLOCK_NV = 0x4002,
        CL_DEVICE_WARP_SIZE_NV = 0x4003,
        CL_DEVICE_GPU_OVERLAP_NV = 0x4004,
        CL_DEVICE_KERNEL_EXEC_TIMEOUT_NV = 0x4005,
        CL_DEVICE_INTEGRATED_MEMORY_NV = 0x4006,
    }

    [SuppressMessage("Design", "CA1028:Enum Storage should be Int32",
        Justification = "Interop enum")]
    [Flags]
    public enum CLBufferFlags : long
    {
        CL_MEM_READ_WRITE = 1 << 0,
        CL_MEM_WRITE_ONLY = 1 << 1,
        CL_MEM_READ_ONLY = 1 << 2,
        CL_MEM_USE_HOST_PTR = 1 << 3,
        CL_MEM_ALLOC_HOST_PTR = 1 << 4,
        CL_MEM_COPY_HOST_PTR = 1 << 5,

        CL_MEM_HOST_WRITE_ONLY = 1 << 7,
        CL_MEM_HOST_READ_ONLY = 1 << 8,
        CL_MEM_HOST_NO_ACCESS = 1 << 9,
        CL_MEM_KERNEL_READ_AND_WRITE = 1 << 12,
    }

    [SuppressMessage("Microsoft.Design", "CA1008:Enums should have zero value",
        Justification = "Interop enum")]
    public enum CLKernelWorkGroupInfoType : int
    {
        CL_KERNEL_WORK_GROUP_SIZE = 0x11B0,
        CL_KERNEL_COMPILE_WORK_GROUP_SIZE = 0x11B1,
        CL_KERNEL_LOCAL_MEM_SIZE = 0x11B2,
        CL_KERNEL_PREFERRED_WORK_GROUP_SIZE_MULTIPLE = 0x11B3,
        CL_KERNEL_PRIVATE_MEM_SIZE = 0x11B4,
        CL_KERNEL_GLOBAL_WORK_SIZE = 0x11B5,
    }

    [SuppressMessage("Microsoft.Design", "CA1008:Enums should have zero value",
        Justification = "Interop enum")]
    public enum CLKernelSubGroupInfoType : int
    {
        CL_KERNEL_MAX_SUB_GROUP_SIZE_FOR_NDRANGE_KHR = 0x2033,
        CL_KERNEL_SUB_GROUP_COUNT_FOR_NDRANGE_KHR = 0x2034,
        CL_KERNEL_LOCAL_SIZE_FOR_SUB_GROUP_COUNT = 0x11B8
    }

    [SuppressMessage("Microsoft.Design", "CA1008:Enums should have zero value",
        Justification = "Interop enum")]
    public enum CLProgramInfo : int
    {
        CL_PROGRAM_REFERENCE_COUNT = 0x1160,
        CL_PROGRAM_CONTEXT = 0x1161,
        CL_PROGRAM_NUM_DEVICES = 0x1162,
        CL_PROGRAM_DEVICES = 0x1163,
        CL_PROGRAM_SOURCE = 0x1164,
        CL_PROGRAM_BINARY_SIZES = 0x1165,
        CL_PROGRAM_BINARIES = 0x1166,
        CL_PROGRAM_NUM_KERNELS = 0x1167,
        CL_PROGRAM_KERNEL_NAMES = 0x1168,
    }

    [SuppressMessage("Microsoft.Design", "CA1008:Enums should have zero value",
        Justification = "Interop enum")]
    public enum CLProgramBuildInfo : int
    {
        CL_PROGRAM_BUILD_STATUS = 0x1181,
        CL_PROGRAM_BUILD_OPTIONS = 0x1182,
        CL_PROGRAM_BUILD_LOG = 0x1183,
        CL_PROGRAM_BINARY_TYPE = 0x1184,
        CL_PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE = 0x1185
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning restore IDE1006 // Naming Styles
