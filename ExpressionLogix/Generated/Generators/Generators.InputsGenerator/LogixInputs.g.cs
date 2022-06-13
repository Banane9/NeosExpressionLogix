using BaseX;
using FrooxEngine;
using FrooxEngine.LogiX;
using FrooxEngine.LogiX.Input;
using System;

namespace ExpressionLogix
{
    public static class LogixInputs
    {
        public static IElementContent<Type> CreateInputNode(this Slot slot, Type value)
        {
            var inputNode = slot.AttachComponent<TypeInput>();
            inputNode.TryGetField<Type>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Byte> CreateInputNode(this Slot slot, Byte value)
        {
            var inputNode = slot.AttachComponent<ByteInput>();
            inputNode.TryGetField<Byte>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<UInt16> CreateInputNode(this Slot slot, UInt16 value)
        {
            var inputNode = slot.AttachComponent<UshortInput>();
            inputNode.TryGetField<UInt16>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<UInt32> CreateInputNode(this Slot slot, UInt32 value)
        {
            var inputNode = slot.AttachComponent<UintInput>();
            inputNode.TryGetField<UInt32>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<UInt64> CreateInputNode(this Slot slot, UInt64 value)
        {
            var inputNode = slot.AttachComponent<UlongInput>();
            inputNode.TryGetField<UInt64>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<SByte> CreateInputNode(this Slot slot, SByte value)
        {
            var inputNode = slot.AttachComponent<SbyteInput>();
            inputNode.TryGetField<SByte>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Int16> CreateInputNode(this Slot slot, Int16 value)
        {
            var inputNode = slot.AttachComponent<ShortInput>();
            inputNode.TryGetField<Int16>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Int32> CreateInputNode(this Slot slot, Int32 value)
        {
            var inputNode = slot.AttachComponent<IntInput>();
            inputNode.TryGetField<Int32>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Int64> CreateInputNode(this Slot slot, Int64 value)
        {
            var inputNode = slot.AttachComponent<LongInput>();
            inputNode.TryGetField<Int64>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Single> CreateInputNode(this Slot slot, Single value)
        {
            var inputNode = slot.AttachComponent<FloatInput>();
            inputNode.TryGetField<Single>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Double> CreateInputNode(this Slot slot, Double value)
        {
            var inputNode = slot.AttachComponent<DoubleInput>();
            inputNode.TryGetField<Double>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Decimal> CreateInputNode(this Slot slot, Decimal value)
        {
            var inputNode = slot.AttachComponent<DecimalInput>();
            inputNode.TryGetField<Decimal>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<uint2> CreateInputNode(this Slot slot, uint2 value)
        {
            var inputNode = slot.AttachComponent<Uint2Input>();
            inputNode.TryGetField<uint2>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<ulong2> CreateInputNode(this Slot slot, ulong2 value)
        {
            var inputNode = slot.AttachComponent<Ulong2Input>();
            inputNode.TryGetField<ulong2>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<int2> CreateInputNode(this Slot slot, int2 value)
        {
            var inputNode = slot.AttachComponent<Int2Input>();
            inputNode.TryGetField<int2>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<long2> CreateInputNode(this Slot slot, long2 value)
        {
            var inputNode = slot.AttachComponent<Long2Input>();
            inputNode.TryGetField<long2>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<float2> CreateInputNode(this Slot slot, float2 value)
        {
            var inputNode = slot.AttachComponent<Float2Input>();
            inputNode.TryGetField<float2>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<double2> CreateInputNode(this Slot slot, double2 value)
        {
            var inputNode = slot.AttachComponent<Double2Input>();
            inputNode.TryGetField<double2>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<uint3> CreateInputNode(this Slot slot, uint3 value)
        {
            var inputNode = slot.AttachComponent<Uint3Input>();
            inputNode.TryGetField<uint3>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<ulong3> CreateInputNode(this Slot slot, ulong3 value)
        {
            var inputNode = slot.AttachComponent<Ulong3Input>();
            inputNode.TryGetField<ulong3>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<int3> CreateInputNode(this Slot slot, int3 value)
        {
            var inputNode = slot.AttachComponent<Int3Input>();
            inputNode.TryGetField<int3>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<long3> CreateInputNode(this Slot slot, long3 value)
        {
            var inputNode = slot.AttachComponent<Long3Input>();
            inputNode.TryGetField<long3>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<float3> CreateInputNode(this Slot slot, float3 value)
        {
            var inputNode = slot.AttachComponent<Float3Input>();
            inputNode.TryGetField<float3>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<double3> CreateInputNode(this Slot slot, double3 value)
        {
            var inputNode = slot.AttachComponent<Double3Input>();
            inputNode.TryGetField<double3>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<uint4> CreateInputNode(this Slot slot, uint4 value)
        {
            var inputNode = slot.AttachComponent<Uint4Input>();
            inputNode.TryGetField<uint4>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<ulong4> CreateInputNode(this Slot slot, ulong4 value)
        {
            var inputNode = slot.AttachComponent<Ulong4Input>();
            inputNode.TryGetField<ulong4>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<int4> CreateInputNode(this Slot slot, int4 value)
        {
            var inputNode = slot.AttachComponent<Int4Input>();
            inputNode.TryGetField<int4>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<long4> CreateInputNode(this Slot slot, long4 value)
        {
            var inputNode = slot.AttachComponent<Long4Input>();
            inputNode.TryGetField<long4>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<float4> CreateInputNode(this Slot slot, float4 value)
        {
            var inputNode = slot.AttachComponent<Float4Input>();
            inputNode.TryGetField<float4>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<double4> CreateInputNode(this Slot slot, double4 value)
        {
            var inputNode = slot.AttachComponent<Double4Input>();
            inputNode.TryGetField<double4>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<TimeSpan> CreateInputNode(this Slot slot, TimeSpan value)
        {
            var inputNode = slot.AttachComponent<TimeSpanInput>();
            inputNode.TryGetField<TimeSpan>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<floatQ> CreateInputNode(this Slot slot, floatQ value)
        {
            var inputNode = slot.AttachComponent<EulerAnglesInput>();
            inputNode.TryGetField<floatQ>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<color> CreateInputNode(this Slot slot, color value)
        {
            var inputNode = slot.AttachComponent<ColorTextInput>();
            inputNode.TryGetField<color>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Rect> CreateInputNode(this Slot slot, Rect value)
        {
            var inputNode = slot.AttachComponent<RectTextInput>();
            inputNode.TryGetField<Rect>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<String> CreateInputNode(this Slot slot, String value)
        {
            var inputNode = slot.AttachComponent<StringInput>();
            inputNode.TryGetField<String>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Char> CreateInputNode(this Slot slot, Char value)
        {
            var inputNode = slot.AttachComponent<CharInput>();
            inputNode.TryGetField<Char>("_value").Value = value;

            return inputNode;
        }

        public static IElementContent<Uri> CreateInputNode(this Slot slot, Uri value)
        {
            var inputNode = slot.AttachComponent<UriInput>();
            inputNode.TryGetField<Uri>("_value").Value = value;

            return inputNode;
        }


    }
}