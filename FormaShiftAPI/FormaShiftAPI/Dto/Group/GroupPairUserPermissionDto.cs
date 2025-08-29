using MessagePack;
using FormaShift.API.Data;
using FormaShift.API.Data.Enum;

namespace FormaShift.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);