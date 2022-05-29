#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2 (void);
// 0x00000003 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000004 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000005 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000006 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000007 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000008 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x00000009 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectManyIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000B System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000C System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::ThenBy(System.Linq.IOrderedEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000E System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::DistinctIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000000F TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000010 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000012 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000013 TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000014 TSource System.Linq.Enumerable::ElementAt(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x00000015 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000016 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000017 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000018 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000019 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x0000001A System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000001B System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x0000001C TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x0000001D System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x0000001E System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x0000001F System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000020 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000021 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000022 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000023 System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x00000024 System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000025 System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x00000026 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000027 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x00000028 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x00000029 System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x0000002A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002B System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002C System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x0000002D System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x0000002E System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x0000002F System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000030 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000031 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000032 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x00000033 System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x00000034 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000035 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000036 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000037 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x00000038 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x00000039 System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x0000003A System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003B System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000003C System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003D System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x0000003E System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x0000003F System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000040 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000041 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000042 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x00000043 System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x00000044 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000045 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000046 System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x00000047 System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x00000048 System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x00000049 TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x0000004A System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::.ctor(System.Int32)
// 0x0000004B System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.IDisposable.Dispose()
// 0x0000004C System.Boolean System.Linq.Enumerable/<SelectManyIterator>d__17`2::MoveNext()
// 0x0000004D System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally1()
// 0x0000004E System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally2()
// 0x0000004F TResult System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x00000050 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.Reset()
// 0x00000051 System.Object System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.get_Current()
// 0x00000052 System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x00000053 System.Collections.IEnumerator System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerable.GetEnumerator()
// 0x00000054 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::.ctor(System.Int32)
// 0x00000055 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.IDisposable.Dispose()
// 0x00000056 System.Boolean System.Linq.Enumerable/<DistinctIterator>d__68`1::MoveNext()
// 0x00000057 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::<>m__Finally1()
// 0x00000058 TSource System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x00000059 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.Reset()
// 0x0000005A System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()
// 0x0000005B System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x0000005C System.Collections.IEnumerator System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000005D System.Linq.IOrderedEnumerable`1<TElement> System.Linq.IOrderedEnumerable`1::CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000005E System.Void System.Linq.Set`1::.ctor(System.Collections.Generic.IEqualityComparer`1<TElement>)
// 0x0000005F System.Boolean System.Linq.Set`1::Add(TElement)
// 0x00000060 System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)
// 0x00000061 System.Void System.Linq.Set`1::Resize()
// 0x00000062 System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)
// 0x00000063 System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x00000064 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000065 System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000066 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.OrderedEnumerable`1::System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000067 System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x00000068 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x00000069 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x0000006A System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x0000006B TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x0000006C System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x0000006D System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x0000006E System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000006F System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000070 System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x00000071 System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x00000072 System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x00000073 System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x00000074 System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x00000075 System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x00000076 System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x00000077 System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x00000078 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x00000079 TElement[] System.Linq.Buffer`1::ToArray()
// 0x0000007A System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x0000007B System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x0000007C System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x0000007D System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x0000007E System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x0000007F System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x00000080 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x00000081 System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x00000082 System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x00000083 System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x00000084 System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x00000085 System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x00000086 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000087 System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000088 System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x00000089 System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x0000008A System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x0000008B System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x0000008C System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x0000008D System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x0000008E System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x0000008F System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x00000090 System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x00000091 System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x00000092 System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x00000093 System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x00000094 T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x00000095 System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x00000096 System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
// 0x00000097 System.Void System.Collections.Generic.ICollectionDebugView`1::.ctor(System.Collections.Generic.ICollection`1<T>)
// 0x00000098 T[] System.Collections.Generic.ICollectionDebugView`1::get_Items()
static Il2CppMethodPointer s_methodPointers[152] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[152] = 
{
	3794,
	3794,
	3922,
	3922,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[50] = 
{
	{ 0x02000004, { 73, 4 } },
	{ 0x02000005, { 77, 9 } },
	{ 0x02000006, { 88, 7 } },
	{ 0x02000007, { 97, 10 } },
	{ 0x02000008, { 109, 11 } },
	{ 0x02000009, { 123, 9 } },
	{ 0x0200000A, { 135, 12 } },
	{ 0x0200000B, { 150, 1 } },
	{ 0x0200000C, { 151, 2 } },
	{ 0x0200000D, { 153, 12 } },
	{ 0x0200000E, { 165, 11 } },
	{ 0x02000010, { 176, 8 } },
	{ 0x02000012, { 184, 3 } },
	{ 0x02000013, { 189, 5 } },
	{ 0x02000014, { 194, 7 } },
	{ 0x02000015, { 201, 3 } },
	{ 0x02000016, { 204, 7 } },
	{ 0x02000017, { 211, 4 } },
	{ 0x02000018, { 215, 21 } },
	{ 0x0200001A, { 236, 2 } },
	{ 0x0200001B, { 238, 2 } },
	{ 0x06000005, { 0, 10 } },
	{ 0x06000006, { 10, 10 } },
	{ 0x06000007, { 20, 5 } },
	{ 0x06000008, { 25, 5 } },
	{ 0x06000009, { 30, 1 } },
	{ 0x0600000A, { 31, 2 } },
	{ 0x0600000B, { 33, 2 } },
	{ 0x0600000C, { 35, 1 } },
	{ 0x0600000D, { 36, 1 } },
	{ 0x0600000E, { 37, 2 } },
	{ 0x0600000F, { 39, 3 } },
	{ 0x06000010, { 42, 2 } },
	{ 0x06000011, { 44, 4 } },
	{ 0x06000012, { 48, 3 } },
	{ 0x06000013, { 51, 3 } },
	{ 0x06000014, { 54, 3 } },
	{ 0x06000015, { 57, 1 } },
	{ 0x06000016, { 58, 3 } },
	{ 0x06000017, { 61, 2 } },
	{ 0x06000018, { 63, 3 } },
	{ 0x06000019, { 66, 2 } },
	{ 0x0600001A, { 68, 5 } },
	{ 0x0600002A, { 86, 2 } },
	{ 0x0600002F, { 95, 2 } },
	{ 0x06000034, { 107, 2 } },
	{ 0x0600003A, { 120, 3 } },
	{ 0x0600003F, { 132, 3 } },
	{ 0x06000044, { 147, 3 } },
	{ 0x06000066, { 187, 2 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[240] = 
{
	{ (Il2CppRGCTXDataType)2, 1967 },
	{ (Il2CppRGCTXDataType)3, 8752 },
	{ (Il2CppRGCTXDataType)2, 3405 },
	{ (Il2CppRGCTXDataType)2, 2880 },
	{ (Il2CppRGCTXDataType)3, 16595 },
	{ (Il2CppRGCTXDataType)2, 2107 },
	{ (Il2CppRGCTXDataType)2, 2887 },
	{ (Il2CppRGCTXDataType)3, 16634 },
	{ (Il2CppRGCTXDataType)2, 2882 },
	{ (Il2CppRGCTXDataType)3, 16602 },
	{ (Il2CppRGCTXDataType)2, 1968 },
	{ (Il2CppRGCTXDataType)3, 8753 },
	{ (Il2CppRGCTXDataType)2, 3428 },
	{ (Il2CppRGCTXDataType)2, 2889 },
	{ (Il2CppRGCTXDataType)3, 16641 },
	{ (Il2CppRGCTXDataType)2, 2126 },
	{ (Il2CppRGCTXDataType)2, 2897 },
	{ (Il2CppRGCTXDataType)3, 16698 },
	{ (Il2CppRGCTXDataType)2, 2893 },
	{ (Il2CppRGCTXDataType)3, 16667 },
	{ (Il2CppRGCTXDataType)2, 681 },
	{ (Il2CppRGCTXDataType)3, 51 },
	{ (Il2CppRGCTXDataType)3, 52 },
	{ (Il2CppRGCTXDataType)2, 1297 },
	{ (Il2CppRGCTXDataType)3, 6764 },
	{ (Il2CppRGCTXDataType)2, 682 },
	{ (Il2CppRGCTXDataType)3, 63 },
	{ (Il2CppRGCTXDataType)3, 64 },
	{ (Il2CppRGCTXDataType)2, 1307 },
	{ (Il2CppRGCTXDataType)3, 6768 },
	{ (Il2CppRGCTXDataType)3, 18974 },
	{ (Il2CppRGCTXDataType)2, 689 },
	{ (Il2CppRGCTXDataType)3, 120 },
	{ (Il2CppRGCTXDataType)2, 2525 },
	{ (Il2CppRGCTXDataType)3, 13034 },
	{ (Il2CppRGCTXDataType)3, 7541 },
	{ (Il2CppRGCTXDataType)3, 18946 },
	{ (Il2CppRGCTXDataType)2, 685 },
	{ (Il2CppRGCTXDataType)3, 74 },
	{ (Il2CppRGCTXDataType)2, 804 },
	{ (Il2CppRGCTXDataType)3, 1044 },
	{ (Il2CppRGCTXDataType)3, 1045 },
	{ (Il2CppRGCTXDataType)2, 2108 },
	{ (Il2CppRGCTXDataType)3, 9395 },
	{ (Il2CppRGCTXDataType)2, 1897 },
	{ (Il2CppRGCTXDataType)2, 1438 },
	{ (Il2CppRGCTXDataType)2, 1561 },
	{ (Il2CppRGCTXDataType)2, 1656 },
	{ (Il2CppRGCTXDataType)2, 1562 },
	{ (Il2CppRGCTXDataType)2, 1657 },
	{ (Il2CppRGCTXDataType)3, 6766 },
	{ (Il2CppRGCTXDataType)2, 1563 },
	{ (Il2CppRGCTXDataType)2, 1658 },
	{ (Il2CppRGCTXDataType)3, 6767 },
	{ (Il2CppRGCTXDataType)2, 1896 },
	{ (Il2CppRGCTXDataType)2, 1560 },
	{ (Il2CppRGCTXDataType)2, 1655 },
	{ (Il2CppRGCTXDataType)2, 1550 },
	{ (Il2CppRGCTXDataType)2, 1551 },
	{ (Il2CppRGCTXDataType)2, 1652 },
	{ (Il2CppRGCTXDataType)3, 6763 },
	{ (Il2CppRGCTXDataType)2, 1437 },
	{ (Il2CppRGCTXDataType)2, 1558 },
	{ (Il2CppRGCTXDataType)2, 1559 },
	{ (Il2CppRGCTXDataType)2, 1654 },
	{ (Il2CppRGCTXDataType)3, 6765 },
	{ (Il2CppRGCTXDataType)2, 1436 },
	{ (Il2CppRGCTXDataType)3, 18933 },
	{ (Il2CppRGCTXDataType)3, 6117 },
	{ (Il2CppRGCTXDataType)2, 1171 },
	{ (Il2CppRGCTXDataType)2, 1553 },
	{ (Il2CppRGCTXDataType)2, 1653 },
	{ (Il2CppRGCTXDataType)2, 1733 },
	{ (Il2CppRGCTXDataType)3, 8754 },
	{ (Il2CppRGCTXDataType)3, 8756 },
	{ (Il2CppRGCTXDataType)2, 479 },
	{ (Il2CppRGCTXDataType)3, 8755 },
	{ (Il2CppRGCTXDataType)3, 8764 },
	{ (Il2CppRGCTXDataType)2, 1971 },
	{ (Il2CppRGCTXDataType)2, 2883 },
	{ (Il2CppRGCTXDataType)3, 16603 },
	{ (Il2CppRGCTXDataType)3, 8765 },
	{ (Il2CppRGCTXDataType)2, 1605 },
	{ (Il2CppRGCTXDataType)2, 1682 },
	{ (Il2CppRGCTXDataType)3, 6775 },
	{ (Il2CppRGCTXDataType)3, 18919 },
	{ (Il2CppRGCTXDataType)2, 2894 },
	{ (Il2CppRGCTXDataType)3, 16668 },
	{ (Il2CppRGCTXDataType)3, 8757 },
	{ (Il2CppRGCTXDataType)2, 1970 },
	{ (Il2CppRGCTXDataType)2, 2881 },
	{ (Il2CppRGCTXDataType)3, 16596 },
	{ (Il2CppRGCTXDataType)3, 6774 },
	{ (Il2CppRGCTXDataType)3, 8758 },
	{ (Il2CppRGCTXDataType)3, 18918 },
	{ (Il2CppRGCTXDataType)2, 2890 },
	{ (Il2CppRGCTXDataType)3, 16642 },
	{ (Il2CppRGCTXDataType)3, 8771 },
	{ (Il2CppRGCTXDataType)2, 1972 },
	{ (Il2CppRGCTXDataType)2, 2888 },
	{ (Il2CppRGCTXDataType)3, 16635 },
	{ (Il2CppRGCTXDataType)3, 9445 },
	{ (Il2CppRGCTXDataType)3, 5194 },
	{ (Il2CppRGCTXDataType)3, 6776 },
	{ (Il2CppRGCTXDataType)3, 5193 },
	{ (Il2CppRGCTXDataType)3, 8772 },
	{ (Il2CppRGCTXDataType)3, 18920 },
	{ (Il2CppRGCTXDataType)2, 2898 },
	{ (Il2CppRGCTXDataType)3, 16699 },
	{ (Il2CppRGCTXDataType)3, 8785 },
	{ (Il2CppRGCTXDataType)2, 1974 },
	{ (Il2CppRGCTXDataType)2, 2896 },
	{ (Il2CppRGCTXDataType)3, 16670 },
	{ (Il2CppRGCTXDataType)3, 8786 },
	{ (Il2CppRGCTXDataType)2, 1608 },
	{ (Il2CppRGCTXDataType)2, 1685 },
	{ (Il2CppRGCTXDataType)3, 6780 },
	{ (Il2CppRGCTXDataType)3, 6779 },
	{ (Il2CppRGCTXDataType)2, 2885 },
	{ (Il2CppRGCTXDataType)3, 16605 },
	{ (Il2CppRGCTXDataType)3, 18927 },
	{ (Il2CppRGCTXDataType)2, 2895 },
	{ (Il2CppRGCTXDataType)3, 16669 },
	{ (Il2CppRGCTXDataType)3, 8778 },
	{ (Il2CppRGCTXDataType)2, 1973 },
	{ (Il2CppRGCTXDataType)2, 2892 },
	{ (Il2CppRGCTXDataType)3, 16644 },
	{ (Il2CppRGCTXDataType)3, 6778 },
	{ (Il2CppRGCTXDataType)3, 6777 },
	{ (Il2CppRGCTXDataType)3, 8779 },
	{ (Il2CppRGCTXDataType)2, 2884 },
	{ (Il2CppRGCTXDataType)3, 16604 },
	{ (Il2CppRGCTXDataType)3, 18926 },
	{ (Il2CppRGCTXDataType)2, 2891 },
	{ (Il2CppRGCTXDataType)3, 16643 },
	{ (Il2CppRGCTXDataType)3, 8792 },
	{ (Il2CppRGCTXDataType)2, 1975 },
	{ (Il2CppRGCTXDataType)2, 2900 },
	{ (Il2CppRGCTXDataType)3, 16701 },
	{ (Il2CppRGCTXDataType)3, 9446 },
	{ (Il2CppRGCTXDataType)3, 5196 },
	{ (Il2CppRGCTXDataType)3, 6782 },
	{ (Il2CppRGCTXDataType)3, 6781 },
	{ (Il2CppRGCTXDataType)3, 5195 },
	{ (Il2CppRGCTXDataType)3, 8793 },
	{ (Il2CppRGCTXDataType)2, 2886 },
	{ (Il2CppRGCTXDataType)3, 16606 },
	{ (Il2CppRGCTXDataType)3, 18928 },
	{ (Il2CppRGCTXDataType)2, 2899 },
	{ (Il2CppRGCTXDataType)3, 16700 },
	{ (Il2CppRGCTXDataType)3, 6771 },
	{ (Il2CppRGCTXDataType)3, 6772 },
	{ (Il2CppRGCTXDataType)3, 6783 },
	{ (Il2CppRGCTXDataType)3, 123 },
	{ (Il2CppRGCTXDataType)3, 122 },
	{ (Il2CppRGCTXDataType)2, 1600 },
	{ (Il2CppRGCTXDataType)2, 1678 },
	{ (Il2CppRGCTXDataType)3, 6773 },
	{ (Il2CppRGCTXDataType)2, 1615 },
	{ (Il2CppRGCTXDataType)2, 1697 },
	{ (Il2CppRGCTXDataType)3, 125 },
	{ (Il2CppRGCTXDataType)2, 617 },
	{ (Il2CppRGCTXDataType)2, 690 },
	{ (Il2CppRGCTXDataType)3, 121 },
	{ (Il2CppRGCTXDataType)3, 124 },
	{ (Il2CppRGCTXDataType)3, 76 },
	{ (Il2CppRGCTXDataType)2, 2624 },
	{ (Il2CppRGCTXDataType)3, 14540 },
	{ (Il2CppRGCTXDataType)2, 1597 },
	{ (Il2CppRGCTXDataType)2, 1676 },
	{ (Il2CppRGCTXDataType)3, 14541 },
	{ (Il2CppRGCTXDataType)3, 78 },
	{ (Il2CppRGCTXDataType)2, 476 },
	{ (Il2CppRGCTXDataType)2, 686 },
	{ (Il2CppRGCTXDataType)3, 75 },
	{ (Il2CppRGCTXDataType)3, 77 },
	{ (Il2CppRGCTXDataType)3, 6153 },
	{ (Il2CppRGCTXDataType)2, 1186 },
	{ (Il2CppRGCTXDataType)2, 3533 },
	{ (Il2CppRGCTXDataType)3, 14537 },
	{ (Il2CppRGCTXDataType)3, 14538 },
	{ (Il2CppRGCTXDataType)2, 1747 },
	{ (Il2CppRGCTXDataType)3, 14539 },
	{ (Il2CppRGCTXDataType)2, 408 },
	{ (Il2CppRGCTXDataType)2, 687 },
	{ (Il2CppRGCTXDataType)3, 88 },
	{ (Il2CppRGCTXDataType)3, 13018 },
	{ (Il2CppRGCTXDataType)2, 2526 },
	{ (Il2CppRGCTXDataType)3, 13035 },
	{ (Il2CppRGCTXDataType)2, 805 },
	{ (Il2CppRGCTXDataType)3, 1046 },
	{ (Il2CppRGCTXDataType)3, 13024 },
	{ (Il2CppRGCTXDataType)3, 5161 },
	{ (Il2CppRGCTXDataType)2, 509 },
	{ (Il2CppRGCTXDataType)3, 13019 },
	{ (Il2CppRGCTXDataType)2, 2522 },
	{ (Il2CppRGCTXDataType)3, 1462 },
	{ (Il2CppRGCTXDataType)2, 824 },
	{ (Il2CppRGCTXDataType)2, 1114 },
	{ (Il2CppRGCTXDataType)3, 5170 },
	{ (Il2CppRGCTXDataType)3, 13020 },
	{ (Il2CppRGCTXDataType)3, 5156 },
	{ (Il2CppRGCTXDataType)3, 5157 },
	{ (Il2CppRGCTXDataType)3, 5155 },
	{ (Il2CppRGCTXDataType)3, 5158 },
	{ (Il2CppRGCTXDataType)2, 1110 },
	{ (Il2CppRGCTXDataType)2, 3489 },
	{ (Il2CppRGCTXDataType)3, 6770 },
	{ (Il2CppRGCTXDataType)3, 5160 },
	{ (Il2CppRGCTXDataType)2, 1528 },
	{ (Il2CppRGCTXDataType)3, 5159 },
	{ (Il2CppRGCTXDataType)2, 1439 },
	{ (Il2CppRGCTXDataType)2, 3432 },
	{ (Il2CppRGCTXDataType)2, 1576 },
	{ (Il2CppRGCTXDataType)2, 1659 },
	{ (Il2CppRGCTXDataType)3, 6136 },
	{ (Il2CppRGCTXDataType)2, 1180 },
	{ (Il2CppRGCTXDataType)3, 7393 },
	{ (Il2CppRGCTXDataType)3, 7394 },
	{ (Il2CppRGCTXDataType)3, 7399 },
	{ (Il2CppRGCTXDataType)2, 1742 },
	{ (Il2CppRGCTXDataType)3, 7396 },
	{ (Il2CppRGCTXDataType)3, 19304 },
	{ (Il2CppRGCTXDataType)2, 1116 },
	{ (Il2CppRGCTXDataType)3, 5187 },
	{ (Il2CppRGCTXDataType)1, 1525 },
	{ (Il2CppRGCTXDataType)2, 3445 },
	{ (Il2CppRGCTXDataType)3, 7395 },
	{ (Il2CppRGCTXDataType)1, 3445 },
	{ (Il2CppRGCTXDataType)1, 1742 },
	{ (Il2CppRGCTXDataType)2, 3531 },
	{ (Il2CppRGCTXDataType)2, 3445 },
	{ (Il2CppRGCTXDataType)3, 7400 },
	{ (Il2CppRGCTXDataType)3, 7398 },
	{ (Il2CppRGCTXDataType)3, 7397 },
	{ (Il2CppRGCTXDataType)2, 335 },
	{ (Il2CppRGCTXDataType)3, 5197 },
	{ (Il2CppRGCTXDataType)2, 489 },
	{ (Il2CppRGCTXDataType)2, 1445 },
	{ (Il2CppRGCTXDataType)2, 3447 },
};
extern const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationSystem_Core;
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	152,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	50,
	s_rgctxIndices,
	240,
	s_rgctxValues,
	&g_DebuggerMetadataRegistrationSystem_Core,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
