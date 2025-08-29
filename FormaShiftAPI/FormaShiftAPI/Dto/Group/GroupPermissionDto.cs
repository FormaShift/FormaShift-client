using MessagePack;
using FormaShift.API.Data;
using FormaShift.API.Data.Enum;

namespace FormaShift.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);