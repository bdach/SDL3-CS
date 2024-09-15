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

using System;
using System.Runtime.InteropServices;

namespace SDL
{
    [NativeTypeName("int")]
    public enum SDL_AudioFormat : uint
    {
        SDL_AUDIO_UNKNOWN = 0x0000U,
        SDL_AUDIO_U8 = 0x0008U,
        SDL_AUDIO_S8 = 0x8008U,
        SDL_AUDIO_S16LE = 0x8010U,
        SDL_AUDIO_S16BE = 0x9010U,
        SDL_AUDIO_S32LE = 0x8020U,
        SDL_AUDIO_S32BE = 0x9020U,
        SDL_AUDIO_F32LE = 0x8120U,
        SDL_AUDIO_F32BE = 0x9120U,
    }

    public partial struct SDL_AudioSpec
    {
        public SDL_AudioFormat format;

        public int channels;

        public int freq;
    }

    public partial struct SDL_AudioStream
    {
    }

    public static unsafe partial class SDL3
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumAudioDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetAudioDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentAudioDriver", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetCurrentAudioDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioDeviceID* SDL_GetAudioPlaybackDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioDeviceID* SDL_GetAudioRecordingDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioDeviceName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetAudioDeviceName(SDL_AudioDeviceID devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetAudioDeviceFormat(SDL_AudioDeviceID devid, SDL_AudioSpec* spec, int* sample_frames);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* SDL_GetAudioDeviceChannelMap(SDL_AudioDeviceID devid, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioDeviceID SDL_OpenAudioDevice(SDL_AudioDeviceID devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_PauseAudioDevice(SDL_AudioDeviceID dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_ResumeAudioDevice(SDL_AudioDeviceID dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_AudioDevicePaused(SDL_AudioDeviceID dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetAudioDeviceGain(SDL_AudioDeviceID devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetAudioDeviceGain(SDL_AudioDeviceID devid, float gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseAudioDevice(SDL_AudioDeviceID devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_BindAudioStreams(SDL_AudioDeviceID devid, SDL_AudioStream** streams, int num_streams);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_BindAudioStream(SDL_AudioDeviceID devid, SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnbindAudioStreams(SDL_AudioStream** streams, int num_streams);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnbindAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioDeviceID SDL_GetAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioStream* SDL_CreateAudioStream([NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PropertiesID SDL_GetAudioStreamProperties(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetAudioStreamFormat(SDL_AudioStream* stream, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetAudioStreamFrequencyRatio(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetAudioStreamGain(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetAudioStreamGain(SDL_AudioStream* stream, float gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* SDL_GetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* SDL_GetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetAudioStreamInputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetAudioStreamOutputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_PutAudioStreamData(SDL_AudioStream* stream, [NativeTypeName("const void *")] IntPtr buf, int len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetAudioStreamData(SDL_AudioStream* stream, [NativeTypeName("void*")] IntPtr buf, int len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetAudioStreamAvailable(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetAudioStreamQueued(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_FlushAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_ClearAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_PauseAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_ResumeAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_LockAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_UnlockAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetAudioStreamGetCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] delegate* unmanaged[Cdecl]<IntPtr, SDL_AudioStream*, int, int, void> callback, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetAudioStreamPutCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] delegate* unmanaged[Cdecl]<IntPtr, SDL_AudioStream*, int, int, void> callback, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioStream* SDL_OpenAudioDeviceStream(SDL_AudioDeviceID devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec, [NativeTypeName("SDL_AudioStreamCallback")] delegate* unmanaged[Cdecl]<IntPtr, SDL_AudioStream*, int, int, void> callback, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetAudioPostmixCallback(SDL_AudioDeviceID devid, [NativeTypeName("SDL_AudioPostmixCallback")] delegate* unmanaged[Cdecl]<IntPtr, SDL_AudioSpec*, float*, int, void> callback, [NativeTypeName("void*")] IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_LoadWAV_IO(SDL_IOStream* src, SDL_bool closeio, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_LoadWAV([NativeTypeName("const char *")] byte* path, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_MixAudio([NativeTypeName("Uint8 *")] byte* dst, [NativeTypeName("const Uint8 *")] byte* src, SDL_AudioFormat format, [NativeTypeName("Uint32")] uint len, float volume);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_ConvertAudioSamples([NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const Uint8 *")] byte* src_data, int src_len, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec, [NativeTypeName("Uint8 **")] byte** dst_data, int* dst_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAudioFormatName", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* Unsafe_SDL_GetAudioFormatName(SDL_AudioFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSilenceValueForFormat(SDL_AudioFormat format);

        [NativeTypeName("#define SDL_AUDIO_MASK_BITSIZE (0xFFu)")]
        public const uint SDL_AUDIO_MASK_BITSIZE = (0xFFU);

        [NativeTypeName("#define SDL_AUDIO_MASK_FLOAT (1u<<8)")]
        public const uint SDL_AUDIO_MASK_FLOAT = (1U << 8);

        [NativeTypeName("#define SDL_AUDIO_MASK_BIG_ENDIAN (1u<<12)")]
        public const uint SDL_AUDIO_MASK_BIG_ENDIAN = (1U << 12);

        [NativeTypeName("#define SDL_AUDIO_MASK_SIGNED (1u<<15)")]
        public const uint SDL_AUDIO_MASK_SIGNED = (1U << 15);

        [NativeTypeName("#define SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK ((SDL_AudioDeviceID) 0xFFFFFFFFu)")]
        public const SDL_AudioDeviceID SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK = ((SDL_AudioDeviceID)(0xFFFFFFFFU));

        [NativeTypeName("#define SDL_AUDIO_DEVICE_DEFAULT_RECORDING ((SDL_AudioDeviceID) 0xFFFFFFFEu)")]
        public const SDL_AudioDeviceID SDL_AUDIO_DEVICE_DEFAULT_RECORDING = ((SDL_AudioDeviceID)(0xFFFFFFFEU));
    }
}
