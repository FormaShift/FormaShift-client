﻿using FormaShift.MareConfiguration.Configurations;

namespace FormaShift.MareConfiguration;

public class XivDataStorageService : ConfigurationServiceBase<XivDataStorageConfig>
{
    public const string ConfigName = "xivdatastorage.json";

    public XivDataStorageService(string configDir) : base(configDir) { }

    public override string ConfigurationName => ConfigName;
}
