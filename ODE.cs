using System;
using System.Runtime.InteropServices;

namespace ODE
{
    public static unsafe class ODE
    {
        private const string LIBNAME = "ode_single";

        [StructLayout(LayoutKind.Sequential)]
        public struct dWorldID : IEquatable<dWorldID>
        {
            public static readonly dWorldID Zero = new dWorldID();

            public readonly IntPtr ID;

            public bool Equals(dWorldID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dWorldID a, dWorldID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dWorldID a, dWorldID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dWorldID && Equals((dWorldID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dSpaceID : IEquatable<dSpaceID>
        {
            public static readonly dSpaceID Zero = new dSpaceID();

            public readonly IntPtr ID;

            public bool Equals(dSpaceID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dSpaceID a, dSpaceID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dSpaceID a, dSpaceID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dSpaceID && Equals((dSpaceID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dBodyID : IEquatable<dBodyID>
        {
            public static readonly dBodyID Zero = new dBodyID();

            public readonly IntPtr ID;

            public bool Equals(dBodyID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dBodyID a, dBodyID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dBodyID a, dBodyID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dBodyID && Equals((dBodyID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dJointID : IEquatable<dJointID>
        {
            public static readonly dJointID Zero = new dJointID();

            public readonly IntPtr ID;

            public bool Equals(dJointID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dJointID a, dJointID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dJointID a, dJointID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dJointID && Equals((dJointID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dJointGroupID : IEquatable<dJointGroupID>
        {
            public static readonly dJointGroupID Zero = new dJointGroupID();

            public readonly IntPtr ID;

            public bool Equals(dJointGroupID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dJointGroupID a, dJointGroupID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dJointGroupID a, dJointGroupID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dJointGroupID && Equals((dJointGroupID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dGeomID : IEquatable<dGeomID>
        {
            public static readonly dGeomID Zero = new dGeomID();

            public readonly IntPtr ID;

            public bool Equals(dGeomID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dGeomID a, dGeomID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dGeomID a, dGeomID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dGeomID && Equals((dGeomID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dHeightfieldDataID : IEquatable<dHeightfieldDataID>
        {
            public static readonly dHeightfieldDataID Zero = new dHeightfieldDataID();

            public readonly IntPtr ID;

            public bool Equals(dHeightfieldDataID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dHeightfieldDataID a, dHeightfieldDataID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dHeightfieldDataID a, dHeightfieldDataID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dHeightfieldDataID && Equals((dHeightfieldDataID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dTriMeshDataID : IEquatable<dTriMeshDataID>
        {
            public static readonly dTriMeshDataID Zero = new dTriMeshDataID();

            public readonly IntPtr ID;

            public bool Equals(dTriMeshDataID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dTriMeshDataID a, dTriMeshDataID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dTriMeshDataID a, dTriMeshDataID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dTriMeshDataID && Equals((dTriMeshDataID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dThreadingThreadPoolID : IEquatable<dThreadingThreadPoolID>
        {
            public static readonly dThreadingThreadPoolID Zero = new dThreadingThreadPoolID();

            public readonly IntPtr ID;

            public bool Equals(dThreadingThreadPoolID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dThreadingThreadPoolID a, dThreadingThreadPoolID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dThreadingThreadPoolID a, dThreadingThreadPoolID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dThreadingThreadPoolID && Equals((dThreadingThreadPoolID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dThreadingImplementationID : IEquatable<dThreadingImplementationID>
        {
            public static readonly dThreadingImplementationID Zero = new dThreadingImplementationID();

            public readonly IntPtr ID;

            public bool Equals(dThreadingImplementationID o)
            {
                return o.ID == ID;
            }

            public static bool operator ==(dThreadingImplementationID a, dThreadingImplementationID b)
            {
                return a.Equals(b);
            }

            public static bool operator !=(dThreadingImplementationID a, dThreadingImplementationID b)
            {
                return !a.Equals(b);
            }

            public override bool Equals(object o)
            {
                return o is dThreadingImplementationID && Equals((dThreadingImplementationID)o);
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }

            public override string ToString()
            {
                return ID.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dVector3
        {
            public fixed float v[4];
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dVector4
        {
            public fixed float v[4];
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dMatrix3
        {
            public fixed float v[12];
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dMatrix4
        {
            public fixed float v[16];
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dQuaternion
        {
            public fixed float v[4];
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void dNearCallback(IntPtr data, dGeomID o1, dGeomID o2);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void dMessageFunction(int errnum, ref sbyte msg, IntPtr ap);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr dAllocFunction(IntPtr size);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr dReallocFunction(IntPtr ptr, IntPtr oldsize, IntPtr newsize);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void dFreeFunction(IntPtr ptr, IntPtr size);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void dGetAABBFn(dGeomID p0, float[] aabb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int dColliderFn(dGeomID o1, dGeomID o2, int flags, ref dContactGeom contact, int skip);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr dGetColliderFnFn(int num);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void dGeomDtorFn(dGeomID o);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int dAABBTestFn(dGeomID o1, dGeomID o2, float[] aabb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float dHeightfieldGetHeight(IntPtr p_user_data, int x, int z);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int dTriCallback(dGeomID TriMesh, dGeomID RefObject, int TriangleIndex);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void dTriArrayCallback(dGeomID TriMesh, dGeomID RefObject, ref int TriIndices, int TriCount);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int dTriRayCallback(dGeomID TriMesh, dGeomID Ray, int TriangleIndex, float u, float v);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int dTriTriMergeCallback(dGeomID TriMesh, int FirstTriangleIndex, int SecondTriangleIndex);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void dThreadReadyToServeCallback(IntPtr callback_context);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int dBodyMovedFn(dBodyID o);

        [StructLayout(LayoutKind.Sequential)]
        public struct dMass
        {
            public float mass;
            public dVector3 c;
            public dMatrix3 I;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dSurfaceParameters
        {
            public int mode;
            public float mu;
            public float mu2;
            public float rho;
            public float rho2;
            public float rhoN;
            public float bounce;
            public float bounce_vel;
            public float soft_erp;
            public float soft_cfm;
            public float motion1;
            public float motion2;
            public float motionN;
            public float slip1;
            public float slip2;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dContactGeom
        {
            public dVector3 pos;
            public float depth;
            public dGeomID g1;
            public dGeomID g2;
            public int side1;
            public int side2;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dContact
        {
            public dSurfaceParameters surface;
            public dContactGeom geom;
            public dVector3 fdir1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dJointFeedback
        {
            public dVector3 f1;
            public dVector3 t1;
            public dVector3 f2;
            public dVector3 t2;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dStopwatch
        {
            public double time;
            public nulong cc0;
            public nulong cc1;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dGeomClass
        {
            public int bytes;
            public IntPtr collider;
            public IntPtr aabb;
            public IntPtr aabb_test;
            public IntPtr dtor;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dWorldStepReserveInfo
        {
            public uint struct_size;
            public float reserve_factor;
            public uint reserve_minimum;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct dWorldStepMemoryFunctionsInfo
        {
            public uint struct_size;
            public IntPtr alloc_block;
            public IntPtr shrink_block;
            public IntPtr free_block;
        }

        public const int dMaxUserClasses = 4;

        public const int dSphereClass = 0;
        public const int dBoxClass = 1;
        public const int dCapsuleClass = 2;
        public const int dCylinderClass = 3;
        public const int dPlaneClass = 4;
        public const int dRayClass = 5;
        public const int dConvexClass = 6;
        public const int dGeomTransformClass = 7;
        public const int dTriMeshClass = 8;
        public const int dHeightfieldClass = 9;
        public const int dFirstSpaceClass = 10;
        public const int dSimpleSpaceClass = 10;
        public const int dHashSpaceClass = 11;
        public const int dSweepAndPruneSpaceClass = 12;
        public const int dQuadTreeSpaceClass = 13;
        public const int dLastSpaceClass = 13;
        public const int dFirstUserClass = 14;

        public const int TRIMESH_FACE_NORMALS = 0;

        public const int d_ERR_UNKNOWN = 0;
        public const int d_ERR_IASSERT = 1;
        public const int d_ERR_UASSERT = 2;
        public const int d_ERR_LCP = 3;

        public enum dJointType
        {
            dJointTypeNone = 0,
            dJointTypeBall,
            dJointTypeHinge,
            dJointTypeSlider,
            dJointTypeContact,
            dJointTypeUniversal,
            dJointTypeHinge2,
            dJointTypeFixed,
            dJointTypeNull,
            dJointTypeAMotor,
            dJointTypeLMotor,
            dJointTypePlane2D,
            dJointTypePR,
            dJointTypePU,
            dJointTypePiston,
            dJointTypeDBall,
            dJointTypeDHinge,
            dJointTypeTransmission,
        }

        public const int dAMotorUser = 0;
        public const int dAMotorEuler = 1;

        public const int dTransmissionParallelAxes = 0;
        public const int dTransmissionIntersectingAxes = 1;
        public const int dTransmissionChainDrive = 2;

        public const int dContactMu2 = 1;
        public const int dContactAxisDep = 1;
        public const int dContactFDir1 = 2;
        public const int dContactBounce = 4;
        public const int dContactSoftERP = 8;
        public const int dContactSoftCFM = 16;
        public const int dContactMotion1 = 32;
        public const int dContactMotion2 = 64;
        public const int dContactMotionN = 128;
        public const int dContactSlip1 = 256;
        public const int dContactSlip2 = 512;
        public const int dContactRolling = 1024;
        public const int dContactApprox0 = 0;
        public const int dContactApprox1_1 = 4096;
        public const int dContactApprox1_2 = 8192;
        public const int dContactApprox1_N = 16384;
        public const int dContactApprox1 = 28672;

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomDestroy(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetData(dGeomID geom, IntPtr data);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGeomGetData(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetBody(dGeomID geom, dBodyID body);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dBodyID dGeomGetBody(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetPosition(dGeomID geom, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetRotation(dGeomID geom, ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetQuaternion(dGeomID geom, ref dQuaternion Q);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dGeomGetPosition(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomCopyPosition(dGeomID geom, ref dVector3 pos);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dGeomGetRotation(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomCopyRotation(dGeomID geom, ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomGetQuaternion(dGeomID geom, ref dQuaternion result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomGetAABB(dGeomID geom, float[] aabb);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomIsSpace(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dSpaceID dGeomGetSpace(dGeomID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomGetClass(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetCategoryBits(dGeomID geom, nulong bits);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetCollideBits(dGeomID geom, nulong bits);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static nulong dGeomGetCategoryBits(dGeomID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static nulong dGeomGetCollideBits(dGeomID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomEnable(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomDisable(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomIsEnabled(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomLowLevelControl(dGeomID geom, int controlClass, int controlCode, IntPtr dataValue, ref int dataSize);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomGetRelPointPos(dGeomID geom, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomGetPosRelPoint(dGeomID geom, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomVectorToWorld(dGeomID geom, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomVectorFromWorld(dGeomID geom, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetOffsetPosition(dGeomID geom, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetOffsetRotation(dGeomID geom, ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetOffsetQuaternion(dGeomID geom, ref dQuaternion Q);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetOffsetWorldPosition(dGeomID geom, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetOffsetWorldRotation(dGeomID geom, ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetOffsetWorldQuaternion(dGeomID geom, ref dQuaternion p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomClearOffset(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomIsOffset(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dGeomGetOffsetPosition(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomCopyOffsetPosition(dGeomID geom, ref dVector3 pos);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dGeomGetOffsetRotation(dGeomID geom);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomCopyOffsetRotation(dGeomID geom, ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomGetOffsetQuaternion(dGeomID geom, ref dQuaternion result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dCollide(dGeomID o1, dGeomID o2, int flags, ref dContactGeom contact, int skip);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSpaceCollide(dSpaceID space, IntPtr data, IntPtr callback);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSpaceCollide2(dGeomID space1, dGeomID space2, IntPtr data, IntPtr callback);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreateSphere(dSpaceID space, float radius);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSphereSetRadius(dGeomID sphere, float radius);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dGeomSphereGetRadius(dGeomID sphere);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dGeomSpherePointDepth(dGeomID sphere, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreateConvex(dSpaceID space, ref float _planes, uint _planecount, ref float _points, uint _pointcount, ref uint _polygons);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomSetConvex(dGeomID g, ref float _planes, uint _count, ref float _points, uint _pointcount, ref uint _polygons);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreateBox(dSpaceID space, float lx, float ly, float lz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomBoxSetLengths(dGeomID box, float lx, float ly, float lz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomBoxGetLengths(dGeomID box, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dGeomBoxPointDepth(dGeomID box, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreatePlane(dSpaceID space, float a, float b, float c, float d);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomPlaneSetParams(dGeomID plane, float a, float b, float c, float d);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomPlaneGetParams(dGeomID plane, ref dVector4 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dGeomPlanePointDepth(dGeomID plane, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreateCapsule(dSpaceID space, float radius, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomCapsuleSetParams(dGeomID ccylinder, float radius, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomCapsuleGetParams(dGeomID ccylinder, ref float radius, ref float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dGeomCapsulePointDepth(dGeomID ccylinder, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreateCylinder(dSpaceID space, float radius, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomCylinderSetParams(dGeomID cylinder, float radius, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomCylinderGetParams(dGeomID cylinder, ref float radius, ref float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreateRay(dSpaceID space, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomRaySetLength(dGeomID ray, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dGeomRayGetLength(dGeomID ray);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomRaySet(dGeomID ray, float px, float py, float pz, float dx, float dy, float dz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomRayGet(dGeomID ray, ref dVector3 start, ref dVector3 dir);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomRaySetFirstContact(dGeomID g, int firstContact);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomRayGetFirstContact(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomRaySetBackfaceCull(dGeomID g, int backfaceCull);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomRayGetBackfaceCull(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomRaySetClosestHit(dGeomID g, int closestHit);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomRayGetClosestHit(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreateHeightfield(dSpaceID space, dHeightfieldDataID data, int bPlaceable);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dHeightfieldDataID dGeomHeightfieldDataCreate();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomHeightfieldDataDestroy(dHeightfieldDataID d);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomHeightfieldDataBuildCallback(dHeightfieldDataID d, IntPtr pUserData, IntPtr pCallback, float width, float depth, int widthSamples, int depthSamples, float scale, float offset, float thickness, int bWrap);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomHeightfieldDataBuildByte(dHeightfieldDataID d, ref byte pHeightData, int bCopyHeightData, float width, float depth, int widthSamples, int depthSamples, float scale, float offset, float thickness, int bWrap);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomHeightfieldDataBuildShort(dHeightfieldDataID d, ref short pHeightData, int bCopyHeightData, float width, float depth, int widthSamples, int depthSamples, float scale, float offset, float thickness, int bWrap);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomHeightfieldDataBuildSingle(dHeightfieldDataID d, ref float pHeightData, int bCopyHeightData, float width, float depth, int widthSamples, int depthSamples, float scale, float offset, float thickness, int bWrap);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomHeightfieldDataBuildDouble(dHeightfieldDataID d, ref double pHeightData, int bCopyHeightData, float width, float depth, int widthSamples, int depthSamples, float scale, float offset, float thickness, int bWrap);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomHeightfieldDataSetBounds(dHeightfieldDataID d, float minHeight, float maxHeight);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomHeightfieldSetHeightfieldData(dGeomID g, dHeightfieldDataID d);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dHeightfieldDataID dGeomHeightfieldGetHeightfieldData(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dClosestLineSegmentPoints(ref dVector3 a1, ref dVector3 a2, ref dVector3 b1, ref dVector3 b2, ref dVector3 cp1, ref dVector3 cp2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBoxTouchesBox(ref dVector3 _p1, ref dMatrix3 R1, ref dVector3 side1, ref dVector3 _p2, ref dMatrix3 R2, ref dVector3 side2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBoxBox(ref dVector3 p1, ref dMatrix3 R1, ref dVector3 side1, ref dVector3 p2, ref dMatrix3 R2, ref dVector3 side2, ref dVector3 normal, ref float depth, ref int return_code, int flags, ref dContactGeom contact, int skip);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dInfiniteAABB(dGeomID geom, float[] aabb);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dCreateGeomClass(ref dGeomClass classptr);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGeomGetClassData(dGeomID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreateGeom(int classnum);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSetColliderOverride(int i, int j, IntPtr fn);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dSpaceID dSimpleSpaceCreate(dSpaceID space);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dSpaceID dHashSpaceCreate(dSpaceID space);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dSpaceID dQuadTreeSpaceCreate(dSpaceID space, ref dVector3 Center, ref dVector3 Extents, int Depth);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dSpaceID dSweepAndPruneSpaceCreate(dSpaceID space, int axisorder);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSpaceDestroy(dSpaceID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dHashSpaceSetLevels(dSpaceID space, int minlevel, int maxlevel);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dHashSpaceGetLevels(dSpaceID space, ref int minlevel, ref int maxlevel);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSpaceSetCleanup(dSpaceID space, int mode);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dSpaceGetCleanup(dSpaceID space);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSpaceSetSublevel(dSpaceID space, int sublevel);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dSpaceGetSublevel(dSpaceID space);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSpaceSetManualCleanup(dSpaceID space, int mode);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dSpaceGetManualCleanup(dSpaceID space);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSpaceAdd(dSpaceID p0, dGeomID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSpaceRemove(dSpaceID p0, dGeomID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dSpaceQuery(dSpaceID p0, dGeomID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSpaceClean(dSpaceID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dSpaceGetNumGeoms(dSpaceID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dSpaceGetGeom(dSpaceID p0, int i);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dSpaceGetClass(dSpaceID space);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dTriMeshDataID dGeomTriMeshDataCreate();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataDestroy(dTriMeshDataID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataSet(dTriMeshDataID g, int data_id, IntPtr in_data);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGeomTriMeshDataGet(dTriMeshDataID g, int data_id);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshSetLastTransform(dGeomID g, ref dMatrix4 last_trans);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dGeomTriMeshGetLastTransform(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataBuildSingle(dTriMeshDataID g, IntPtr Vertices, int VertexStride, int VertexCount, IntPtr Indices, int IndexCount, int TriStride);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataBuildSingle1(dTriMeshDataID g, IntPtr Vertices, int VertexStride, int VertexCount, IntPtr Indices, int IndexCount, int TriStride, IntPtr Normals);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataBuildDouble(dTriMeshDataID g, IntPtr Vertices, int VertexStride, int VertexCount, IntPtr Indices, int IndexCount, int TriStride);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataBuildDouble1(dTriMeshDataID g, IntPtr Vertices, int VertexStride, int VertexCount, IntPtr Indices, int IndexCount, int TriStride, IntPtr Normals);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataBuildSimple(dTriMeshDataID g, ref float Vertices, int VertexCount, ref uint Indices, int IndexCount);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataBuildSimple1(dTriMeshDataID g, ref float Vertices, int VertexCount, ref uint Indices, int IndexCount, ref int Normals);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataPreprocess(dTriMeshDataID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataGetBuffer(dTriMeshDataID g, ref byte* buf, ref int bufLen);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataSetBuffer(dTriMeshDataID g, ref byte buf);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshSetCallback(dGeomID g, IntPtr Callback);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGeomTriMeshGetCallback(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshSetArrayCallback(dGeomID g, IntPtr ArrayCallback);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGeomTriMeshGetArrayCallback(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshSetRayCallback(dGeomID g, IntPtr Callback);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGeomTriMeshGetRayCallback(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshSetTriMergeCallback(dGeomID g, IntPtr Callback);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGeomTriMeshGetTriMergeCallback(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dCreateTriMesh(dSpaceID space, dTriMeshDataID Data, IntPtr Callback, IntPtr ArrayCallback, IntPtr RayCallback);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshSetData(dGeomID g, dTriMeshDataID Data);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dTriMeshDataID dGeomTriMeshGetData(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshEnableTC(dGeomID g, int geomClass, int enable);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomTriMeshIsTCEnabled(dGeomID g, int geomClass);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshClearTCCache(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dTriMeshDataID dGeomTriMeshGetTriMeshDataID(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshGetTriangle(dGeomID g, int Index, ref dVector3* v0, ref dVector3* v1, ref dVector3* v2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshGetPoint(dGeomID g, int Index, float u, float v, ref dVector3 Out);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dGeomTriMeshGetTriangleCount(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dGeomTriMeshDataUpdate(dTriMeshDataID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static sbyte* dGetConfiguration();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dCheckConfiguration(ref sbyte token);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSetErrorHandler(IntPtr fn);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSetDebugHandler(IntPtr fn);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSetMessageHandler(IntPtr fn);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGetErrorHandler();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGetDebugHandler();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGetMessageHandler();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dError(int num, ref sbyte msg);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dDebug(int num, ref sbyte msg);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMessage(int num, ref sbyte msg);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldExportDIF(dWorldID w, IntPtr file, ref sbyte world_name);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dMassCheck(ref dMass m);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetZero(ref dMass p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetParameters(ref dMass p0, float themass, float cgx, float cgy, float cgz, float I11, float I22, float I33, float I12, float I13, float I23);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetSphere(ref dMass p0, float density, float radius);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetSphereTotal(ref dMass p0, float total_mass, float radius);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetCapsule(ref dMass p0, float density, int direction, float radius, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetCapsuleTotal(ref dMass p0, float total_mass, int direction, float radius, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetCylinder(ref dMass p0, float density, int direction, float radius, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetCylinderTotal(ref dMass p0, float total_mass, int direction, float radius, float length);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetBox(ref dMass p0, float density, float lx, float ly, float lz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetBoxTotal(ref dMass p0, float total_mass, float lx, float ly, float lz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetTrimesh(ref dMass p0, float density, dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassSetTrimeshTotal(ref dMass m, float total_mass, dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassAdjust(ref dMass p0, float newmass);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassTranslate(ref dMass p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassRotate(ref dMass p0, ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMassAdd(ref dMass a, ref dMass b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSetZero(ref float a, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSetValue(ref float a, int n, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dDot(ref float a, ref float b, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMultiply0(ref float A, ref float B, ref float C, int p, int q, int r);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMultiply1(ref float A, ref float B, ref float C, int p, int q, int r);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMultiply2(ref float A, ref float B, ref float C, int p, int q, int r);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dFactorCholesky(ref float A, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSolveCholesky(ref float L, ref float b, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dInvertPDMatrix(ref float A, ref float Ainv, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dIsPositiveDefinite(ref float A, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dFactorLDLT(ref float A, ref float d, int n, int nskip);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSolveL1(ref float L, ref float b, int n, int nskip);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSolveL1T(ref float L, ref float b, int n, int nskip);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dVectorScale(ref float a, ref float d, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSolveLDLT(ref float L, ref float d, ref float b, int n, int nskip);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dLDLTAddTL(ref float L, ref float d, ref float a, int n, int nskip);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dLDLTRemove(ref float* A, ref int p, ref float L, ref float d, int n1, int n2, int r, int nskip);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dRemoveRowCol(ref float A, int n, int nskip, int r);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSetAllocHandler(IntPtr fn);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSetReallocHandler(IntPtr fn);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dSetFreeHandler(IntPtr fn);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGetAllocHandler();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGetReallocHandler();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dGetFreeHandler();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dAlloc(IntPtr size);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dRealloc(IntPtr ptr, IntPtr oldsize, IntPtr newsize);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dFree(IntPtr ptr, IntPtr size);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dTestRand();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static nulong dRand();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static nulong dRandGetSeed();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dRandSetSeed(nulong s);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dRandInt(int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dRandReal();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dPrintMatrix(ref float A, int n, int m, ref sbyte fmt, IntPtr f);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMakeRandomVector(ref float A, int n, float range);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dMakeRandomMatrix(ref float A, int n, int m, float range);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dClearUpperTriangle(ref float A, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dMaxDifference(ref float A, ref float B, int n, int m);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dMaxDifferenceLowerTriangle(ref float A, ref float B, int n);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dWorldID dWorldCreate();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldDestroy(dWorldID world);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetData(dWorldID world, IntPtr data);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dWorldGetData(dWorldID world);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetGravity(dWorldID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldGetGravity(dWorldID p0, ref dVector3 gravity);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetERP(dWorldID p0, float erp);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetERP(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetCFM(dWorldID p0, float cfm);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetCFM(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetStepIslandsProcessingMaxThreadCount(dWorldID w, uint count);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static uint dWorldGetStepIslandsProcessingMaxThreadCount(dWorldID w);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dWorldUseSharedWorkingMemory(dWorldID w, dWorldID from_world);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldCleanupWorkingMemory(dWorldID w);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dWorldSetStepMemoryReservationPolicy(dWorldID w, ref dWorldStepReserveInfo policyinfo);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dWorldSetStepMemoryManager(dWorldID w, ref dWorldStepMemoryFunctionsInfo memfuncs);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetStepThreadingImplementation(dWorldID w, IntPtr functions_info, dThreadingImplementationID threading_impl);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dWorldStep(dWorldID w, float stepsize);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dWorldQuickStep(dWorldID w, float stepsize);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldImpulseToForce(dWorldID p0, float stepsize, float ix, float iy, float iz, ref dVector3 force);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetQuickStepNumIterations(dWorldID p0, int num);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dWorldGetQuickStepNumIterations(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetQuickStepW(dWorldID p0, float over_relaxation);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetQuickStepW(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetContactMaxCorrectingVel(dWorldID p0, float vel);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetContactMaxCorrectingVel(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetContactSurfaceLayer(dWorldID p0, float depth);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetContactSurfaceLayer(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetAutoDisableLinearThreshold(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetAutoDisableLinearThreshold(dWorldID p0, float linear_average_threshold);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetAutoDisableAngularThreshold(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetAutoDisableAngularThreshold(dWorldID p0, float angular_average_threshold);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dWorldGetAutoDisableAverageSamplesCount(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetAutoDisableAverageSamplesCount(dWorldID p0, uint average_samples_count);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dWorldGetAutoDisableSteps(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetAutoDisableSteps(dWorldID p0, int steps);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetAutoDisableTime(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetAutoDisableTime(dWorldID p0, float time);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dWorldGetAutoDisableFlag(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetAutoDisableFlag(dWorldID p0, int do_auto_disable);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetLinearDampingThreshold(dWorldID w);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetLinearDampingThreshold(dWorldID w, float threshold);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetAngularDampingThreshold(dWorldID w);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetAngularDampingThreshold(dWorldID w, float threshold);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetLinearDamping(dWorldID w);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetLinearDamping(dWorldID w, float scale);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetAngularDamping(dWorldID w);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetAngularDamping(dWorldID w, float scale);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetDamping(dWorldID w, float linear_scale, float angular_scale);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dWorldGetMaxAngularSpeed(dWorldID w);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dWorldSetMaxAngularSpeed(dWorldID w, float max_speed);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dBodyGetAutoDisableLinearThreshold(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAutoDisableLinearThreshold(dBodyID p0, float linear_average_threshold);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dBodyGetAutoDisableAngularThreshold(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAutoDisableAngularThreshold(dBodyID p0, float angular_average_threshold);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBodyGetAutoDisableAverageSamplesCount(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAutoDisableAverageSamplesCount(dBodyID p0, uint average_samples_count);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBodyGetAutoDisableSteps(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAutoDisableSteps(dBodyID p0, int steps);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dBodyGetAutoDisableTime(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAutoDisableTime(dBodyID p0, float time);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBodyGetAutoDisableFlag(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAutoDisableFlag(dBodyID p0, int do_auto_disable);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAutoDisableDefaults(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dWorldID dBodyGetWorld(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dBodyID dBodyCreate(dWorldID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyDestroy(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetData(dBodyID p0, IntPtr data);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dBodyGetData(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetPosition(dBodyID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetRotation(dBodyID p0, ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetQuaternion(dBodyID p0, ref dQuaternion q);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetLinearVel(dBodyID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAngularVel(dBodyID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dBodyGetPosition(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyCopyPosition(dBodyID body, ref dVector3 pos);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dBodyGetRotation(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyCopyRotation(dBodyID p0, ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dBodyGetQuaternion(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyCopyQuaternion(dBodyID body, ref dQuaternion quat);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dBodyGetLinearVel(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dBodyGetAngularVel(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetMass(dBodyID p0, ref dMass mass);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyGetMass(dBodyID p0, ref dMass mass);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyAddForce(dBodyID p0, float fx, float fy, float fz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyAddTorque(dBodyID p0, float fx, float fy, float fz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyAddRelForce(dBodyID p0, float fx, float fy, float fz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyAddRelTorque(dBodyID p0, float fx, float fy, float fz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyAddForceAtPos(dBodyID p0, float fx, float fy, float fz, float px, float py, float pz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyAddForceAtRelPos(dBodyID p0, float fx, float fy, float fz, float px, float py, float pz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyAddRelForceAtPos(dBodyID p0, float fx, float fy, float fz, float px, float py, float pz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyAddRelForceAtRelPos(dBodyID p0, float fx, float fy, float fz, float px, float py, float pz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dBodyGetForce(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float* dBodyGetTorque(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetForce(dBodyID b, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetTorque(dBodyID b, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyGetRelPointPos(dBodyID p0, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyGetRelPointVel(dBodyID p0, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyGetPointVel(dBodyID p0, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyGetPosRelPoint(dBodyID p0, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyVectorToWorld(dBodyID p0, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyVectorFromWorld(dBodyID p0, float px, float py, float pz, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetFiniteRotationMode(dBodyID p0, int mode);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetFiniteRotationAxis(dBodyID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBodyGetFiniteRotationMode(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyGetFiniteRotationAxis(dBodyID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBodyGetNumJoints(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dBodyGetJoint(dBodyID p0, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetDynamic(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetKinematic(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBodyIsKinematic(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyEnable(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodyDisable(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBodyIsEnabled(dBodyID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetGravityMode(dBodyID b, int mode);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBodyGetGravityMode(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetMovedCallback(dBodyID b, IntPtr callback);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dBodyGetFirstGeom(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dGeomID dBodyGetNextGeom(dGeomID g);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetDampingDefaults(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dBodyGetLinearDamping(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetLinearDamping(dBodyID b, float scale);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dBodyGetAngularDamping(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAngularDamping(dBodyID b, float scale);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetDamping(dBodyID b, float linear_scale, float angular_scale);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dBodyGetLinearDampingThreshold(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetLinearDampingThreshold(dBodyID b, float threshold);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dBodyGetAngularDampingThreshold(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetAngularDampingThreshold(dBodyID b, float threshold);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dBodyGetMaxAngularSpeed(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetMaxAngularSpeed(dBodyID b, float max_speed);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dBodyGetGyroscopicMode(dBodyID b);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dBodySetGyroscopicMode(dBodyID b, int enabled);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateBall(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateHinge(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateSlider(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateContact(dWorldID p0, dJointGroupID p1, ref dContact p2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateHinge2(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateUniversal(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreatePR(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreatePU(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreatePiston(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateFixed(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateNull(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateAMotor(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateLMotor(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreatePlane2D(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateDBall(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateDHinge(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dJointCreateTransmission(dWorldID p0, dJointGroupID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointDestroy(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointGroupID dJointGroupCreate(int max_size);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGroupDestroy(dJointGroupID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGroupEmpty(dJointGroupID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dJointGetNumBodies(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointAttach(dJointID p0, dBodyID body1, dBodyID body2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointEnable(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointDisable(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dJointIsEnabled(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetData(dJointID p0, IntPtr data);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dJointGetData(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointType dJointGetType(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dBodyID dJointGetBody(dJointID p0, int index);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetFeedback(dJointID p0, ref dJointFeedback p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointFeedback* dJointGetFeedback(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetBallAnchor(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetBallAnchor2(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetBallParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetHingeAnchor(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetHingeAnchorDelta(dJointID p0, float x, float y, float z, float ax, float ay, float az);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetHingeAxis(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetHingeAxisOffset(dJointID j, float x, float y, float z, float angle);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetHingeParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointAddHingeTorque(dJointID joint, float torque);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetSliderAxis(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetSliderAxisDelta(dJointID p0, float x, float y, float z, float ax, float ay, float az);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetSliderParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointAddSliderForce(dJointID joint, float force);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetHinge2Anchor(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetHinge2Axis1(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetHinge2Axis2(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetHinge2Param(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointAddHinge2Torques(dJointID joint, float torque1, float torque2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetUniversalAnchor(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetUniversalAxis1(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetUniversalAxis1Offset(dJointID p0, float x, float y, float z, float offset1, float offset2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetUniversalAxis2(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetUniversalAxis2Offset(dJointID p0, float x, float y, float z, float offset1, float offset2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetUniversalParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointAddUniversalTorques(dJointID joint, float torque1, float torque2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPRAnchor(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPRAxis1(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPRAxis2(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPRParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointAddPRTorque(dJointID j, float torque);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPUAnchor(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPUAnchorOffset(dJointID p0, float x, float y, float z, float dx, float dy, float dz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPUAxis1(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPUAxis2(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPUAxis3(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPUAxisP(dJointID id, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPUParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointAddPUTorque(dJointID j, float torque);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPistonAnchor(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPistonAnchorOffset(dJointID j, float x, float y, float z, float dx, float dy, float dz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPistonAxis(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPistonParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointAddPistonForce(dJointID joint, float force);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetFixed(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetFixedParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetAMotorNumAxes(dJointID p0, int num);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetAMotorAxis(dJointID p0, int anum, int rel, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetAMotorAngle(dJointID p0, int anum, float angle);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetAMotorParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetAMotorMode(dJointID p0, int mode);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointAddAMotorTorques(dJointID p0, float torque1, float torque2, float torque3);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetLMotorNumAxes(dJointID p0, int num);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetLMotorAxis(dJointID p0, int anum, int rel, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetLMotorParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPlane2DXParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPlane2DYParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetPlane2DAngleParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetBallAnchor(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetBallAnchor2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetBallParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetHingeAnchor(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetHingeAnchor2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetHingeAxis(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetHingeParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetHingeAngle(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetHingeAngleRate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetSliderPosition(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetSliderPositionRate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetSliderAxis(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetSliderParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetHinge2Anchor(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetHinge2Anchor2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetHinge2Axis1(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetHinge2Axis2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetHinge2Param(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetHinge2Angle1(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetHinge2Angle2(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetHinge2Angle1Rate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetHinge2Angle2Rate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetUniversalAnchor(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetUniversalAnchor2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetUniversalAxis1(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetUniversalAxis2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetUniversalParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetUniversalAngles(dJointID p0, ref float angle1, ref float angle2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetUniversalAngle1(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetUniversalAngle2(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetUniversalAngle1Rate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetUniversalAngle2Rate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPRAnchor(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPRPosition(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPRPositionRate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPRAngle(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPRAngleRate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPRAxis1(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPRAxis2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPRParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPUAnchor(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPUPosition(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPUPositionRate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPUAxis1(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPUAxis2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPUAxis3(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPUAxisP(dJointID id, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPUAngles(dJointID p0, ref float angle1, ref float angle2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPUAngle1(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPUAngle1Rate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPUAngle2(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPUAngle2Rate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPUParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPistonPosition(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPistonPositionRate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPistonAngle(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPistonAngleRate(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPistonAnchor(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPistonAnchor2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetPistonAxis(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetPistonParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dJointGetAMotorNumAxes(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetAMotorAxis(dJointID p0, int anum, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dJointGetAMotorAxisRel(dJointID p0, int anum);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetAMotorAngle(dJointID p0, int anum);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetAMotorAngleRate(dJointID p0, int anum);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetAMotorParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dJointGetAMotorMode(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dJointGetLMotorNumAxes(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetLMotorAxis(dJointID p0, int anum, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetLMotorParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetFixedParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetTransmissionContactPoint1(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetTransmissionContactPoint2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionAxis1(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetTransmissionAxis1(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionAxis2(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetTransmissionAxis2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionAnchor1(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetTransmissionAnchor1(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionAnchor2(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetTransmissionAnchor2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetTransmissionParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionMode(dJointID j, int mode);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dJointGetTransmissionMode(dJointID j);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionRatio(dJointID j, float ratio);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetTransmissionRatio(dJointID j);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionAxis(dJointID j, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetTransmissionAxis(dJointID j, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetTransmissionAngle1(dJointID j);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetTransmissionAngle2(dJointID j);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetTransmissionRadius1(dJointID j);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetTransmissionRadius2(dJointID j);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionRadius1(dJointID j, float radius);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionRadius2(dJointID j, float radius);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetTransmissionBacklash(dJointID j);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetTransmissionBacklash(dJointID j, float backlash);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetDBallAnchor1(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetDBallAnchor2(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetDBallAnchor1(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetDBallAnchor2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetDBallDistance(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetDBallDistance(dJointID p0, float dist);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetDBallParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetDBallParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetDHingeAxis(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetDHingeAxis(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetDHingeAnchor1(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetDHingeAnchor2(dJointID p0, float x, float y, float z);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetDHingeAnchor1(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointGetDHingeAnchor2(dJointID p0, ref dVector3 result);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetDHingeDistance(dJointID p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dJointSetDHingeParam(dJointID p0, int parameter, float value);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static float dJointGetDHingeParam(dJointID p0, int parameter);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dJointID dConnectingJoint(dBodyID p0, dBodyID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dConnectingJointList(dBodyID p0, dBodyID p1, ref dJointID p2);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dAreConnected(dBodyID p0, dBodyID p1);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dAreConnectedExcluding(dBodyID body1, dBodyID body2, int joint_type);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dInitODE();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dInitODE2(uint uiInitFlags);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dAllocateODEDataForThread(uint uiAllocateFlags);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dCleanupODEAllDataForThread();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dCloseODE();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dSafeNormalize3(ref dVector3 a);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static int dSafeNormalize4(ref dVector4 a);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dNormalize3(ref dVector3 a);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dNormalize4(ref dVector4 a);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dPlaneSpace(ref dVector3 n, ref dVector3 p, ref dVector3 q);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dOrthogonalizeR(ref dMatrix3 m);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dRSetIdentity(ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dRFromAxisAndAngle(ref dMatrix3 R, float ax, float ay, float az, float angle);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dRFromEulerAngles(ref dMatrix3 R, float phi, float theta, float psi);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dRFrom2Axes(ref dMatrix3 R, float ax, float ay, float az, float bx, float by, float bz);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dRFromZAxis(ref dMatrix3 R, float ax, float ay, float az);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dQSetIdentity(ref dQuaternion q);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dQFromAxisAndAngle(ref dQuaternion q, float ax, float ay, float az, float angle);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dQMultiply0(ref dQuaternion qa, ref dQuaternion qb, ref dQuaternion qc);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dQMultiply1(ref dQuaternion qa, ref dQuaternion qb, ref dQuaternion qc);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dQMultiply2(ref dQuaternion qa, ref dQuaternion qb, ref dQuaternion qc);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dQMultiply3(ref dQuaternion qa, ref dQuaternion qb, ref dQuaternion qc);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dRfromQ(ref dMatrix3 R, ref dQuaternion q);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dQfromR(ref dQuaternion q, ref dMatrix3 R);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dDQfromW(float[] dq, ref dVector3 w, ref dQuaternion q);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dThreadingImplementationID dThreadingAllocateMultiThreadedImplementation();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr dThreadingImplementationGetFunctions(dThreadingImplementationID impl);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dThreadingImplementationShutdownProcessing(dThreadingImplementationID impl);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dThreadingImplementationCleanupForRestart(dThreadingImplementationID impl);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dThreadingFreeImplementation(dThreadingImplementationID impl);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dExternalThreadingServeMultiThreadedImplementation(dThreadingImplementationID impl, IntPtr readiness_callback, IntPtr callback_context);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static dThreadingThreadPoolID dThreadingAllocateThreadPool(uint thread_count, IntPtr stack_size, uint ode_data_allocate_flags, IntPtr reserved);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dThreadingThreadPoolServeMultiThreadedImplementation(dThreadingThreadPoolID pool, dThreadingImplementationID impl);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dThreadingThreadPoolWaitIdleState(dThreadingThreadPoolID pool);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dThreadingFreeThreadPool(dThreadingThreadPoolID pool);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dStopwatchReset(ref dStopwatch p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dStopwatchStart(ref dStopwatch p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dStopwatchStop(ref dStopwatch p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static double dStopwatchTime(ref dStopwatch p0);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dTimerStart(ref sbyte description);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dTimerNow(ref sbyte description);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dTimerEnd();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static void dTimerReport(IntPtr fout, int average);

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static double dTimerTicksPerSecond();

        [DllImport(LIBNAME, CallingConvention = CallingConvention.Cdecl)]
        public extern static double dTimerResolution();
    }
}
