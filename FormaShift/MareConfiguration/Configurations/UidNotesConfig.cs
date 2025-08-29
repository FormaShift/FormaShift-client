using FormaShift.MareConfiguration.Models;

namespace FormaShift.MareConfiguration.Configurations;

public class UidNotesConfig : IMareConfiguration
{
    public Dictionary<string, ServerNotesStorage> ServerNotes { get; set; } = new(StringComparer.Ordinal);
    public int Version { get; set; } = 0;
}
