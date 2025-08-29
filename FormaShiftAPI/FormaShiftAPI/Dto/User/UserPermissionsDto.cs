using MessagePack;
using FormaShift.API.Data;
using FormaShift.API.Data.Enum;

namespace FormaShift.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);
