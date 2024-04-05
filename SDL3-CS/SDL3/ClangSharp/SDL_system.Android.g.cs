/*
  <auto-generated/>
  C# bindings for Simple DirectMedia Layer.
  Original copyright notice of input files:

  Simple DirectMedia Layer
  Copyright (C) 1997-2024 Sam Lantinga <slouken@libsdl.org>

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace SDL
{
    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SupportedOSPlatform("Android")]
        public static extern void* SDL_AndroidGetJNIEnv();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SupportedOSPlatform("Android")]
        public static extern void* SDL_AndroidGetActivity();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SupportedOSPlatform("Android")]
        public static extern int SDL_GetAndroidSDKVersion();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        [SupportedOSPlatform("Android")]
        public static extern int SDL_IsAndroidTV();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        [SupportedOSPlatform("Android")]
        public static extern int SDL_IsChromebook();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_bool")]
        [SupportedOSPlatform("Android")]
        public static extern int SDL_IsDeXMode();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SupportedOSPlatform("Android")]
        public static extern void SDL_AndroidBackButton();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        [SupportedOSPlatform("Android")]
        public static extern sbyte* SDL_AndroidGetInternalStoragePath();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SupportedOSPlatform("Android")]
        public static extern int SDL_AndroidGetExternalStorageState([NativeTypeName("Uint32 *")] uint* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        [SupportedOSPlatform("Android")]
        public static extern sbyte* SDL_AndroidGetExternalStoragePath();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SupportedOSPlatform("Android")]
        public static extern int SDL_AndroidRequestPermission([NativeTypeName("const char *")] sbyte* permission, [NativeTypeName("SDL_AndroidRequestPermissionCallback")] delegate* unmanaged[Cdecl]<void*, sbyte*, int, void> cb, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SupportedOSPlatform("Android")]
        public static extern int SDL_AndroidShowToast([NativeTypeName("const char *")] sbyte* message, int duration, int gravity, int xoffset, int yoffset);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [SupportedOSPlatform("Android")]
        public static extern int SDL_AndroidSendMessage([NativeTypeName("Uint32")] uint command, int param1);

        [NativeTypeName("#define SDL_ANDROID_EXTERNAL_STORAGE_READ 0x01")]
        public const int SDL_ANDROID_EXTERNAL_STORAGE_READ = 0x01;

        [NativeTypeName("#define SDL_ANDROID_EXTERNAL_STORAGE_WRITE 0x02")]
        public const int SDL_ANDROID_EXTERNAL_STORAGE_WRITE = 0x02;
    }
}
