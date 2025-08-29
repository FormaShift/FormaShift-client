using MessagePack;
using FormaShift.API.Data;

namespace FormaShift.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserDto(UserData User);