using MessagePack;

namespace FormaShift.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record CensusDataDto(ushort WorldId, short RaceId, short TribeId, short Gender);