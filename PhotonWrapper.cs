using ExitGames.Client.Photon;
using System;
using System.Collections.Generic;
using Vanished.API.Patches;
using VRC.SDKBase;

namespace Vanished.API.Extensions
{
    static class PhotonExtensions
    {
        public static byte[] CopyServerTimeAndActorId(byte[] array)
        {
            byte[] src = new byte[4];
            byte[] bytes = BitConverter.GetBytes(Networking.GetServerTimeInMilliseconds());
            Buffer.BlockCopy(src, 0, array, 0, 4);
            Buffer.BlockCopy(bytes, 0, array, 4, 4);

            return array;
        }

        public static void OpRaise(this Dictionary<byte, object> dictionary, byte code)
        {
            OpRaiseEvent(code, dictionary, new ObjectPublicObByObInByObObUnique { field_Public_EnumPublicSealedvaDoMeReAdReSlAd13SlUnique_0 = 0, field_Public_EnumPublicSealedvaOtAlMa4vUnique_0 = 0 }, SendOptions.SendReliable);
        }

        public static void OpRaise(this Il2CppSystem.Object @object, byte code)
        {
            OpRaiseEvent(code, @object, new ObjectPublicObByObInByObObUnique { field_Public_EnumPublicSealedvaDoMeReAdReSlAd13SlUnique_0 = 0, field_Public_EnumPublicSealedvaOtAlMa4vUnique_0 = 0 }, SendOptions.SendReliable);
        }

        public static void OpRaise(this byte[] bytes, byte code)
        {
            OpRaiseEvent(code, bytes, new ObjectPublicObByObInByObObUnique { field_Public_EnumPublicSealedvaDoMeReAdReSlAd13SlUnique_0 = 0, field_Public_EnumPublicSealedvaOtAlMa4vUnique_0 = 0 }, SendOptions.SendReliable);
        }

        public static void OpRaiseEvent(byte code, object customObject, ObjectPublicObByObInByObObUnique RaiseEventOptions, SendOptions sendOptions)
        {
            Il2CppSystem.Object Object = VanishPatches.FromManagedToIL2CPP<Il2CppSystem.Object>(customObject);
            OpRaiseEvent(code, Object, RaiseEventOptions, sendOptions);
        }

        public static void OpRaiseEvent(byte code, Il2CppSystem.Object customObject, ObjectPublicObByObInByObObUnique RaiseEventOptions, SendOptions sendOptions)
        {
            ObjectPublicAbstractSealedPhObInStObInHa1InDiUnique.Method_Public_Static_Boolean_Byte_Object_ObjectPublicObByObInByObObUnique_SendOptions_0(code, customObject, RaiseEventOptions, sendOptions);
        }
    }
}
