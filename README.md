https://www.youtube.com/watch?v=UQ2GdLzMmbE // Video

dotnet ef database update // 로컬에 데이터 마이그레이션 시작 명령어












https://stackoverflow.com/questions/8877460/generating-guid-without-hyphen // bugfix

Note that you are talking about the (canonical) string representation of a Guid. The Guid itself is actually a 128-bit integer value.

You can use the "N" specifier with the Guid.ToString(String) overload.

Guid.NewGuid().ToString("N");
By default letters are lowercase. A Guid with only uppercase letters can only be achieved by manually converting them all to uppercase, example:

Guid.NewGuid().ToString("N").ToUpper();
A guid with only either letter or digits makes no sense. A guid string representation is hexadecimal, and thus will always (well most likely) contain both.