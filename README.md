# UniStringParseExtensionMethods

文字列を他の型に変換する拡張メソッド

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        // 文字列を以下の型に変換する拡張メソッド
        // sbyte, byte, char, short, ushort, int, uint, long, ulong
        // float, double, decimal, DateTime, bool, enum

        var str = "1";

        int  r1 = str.ToInt();              // int に変換
        int? r2 = str.ToIntOrNull();        // int に変換。変換できない場合は null を取得
        int  r3 = str.ToIntOrDefault();     // int に変換。変換できない場合は既定値を取得
        int  r4 = str.ToIntOrDefault( 25 ); // int に変換。変換できない場合は引数に渡した値を取得
        bool r5 = str.IsInt();              // int に変換できる場合 true
    }
}
```
