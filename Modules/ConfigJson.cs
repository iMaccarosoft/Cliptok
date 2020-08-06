﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MicrosoftBot
{
    public class UserWarning
    {
        [JsonProperty("targetUserId")]
        public ulong TargetUserId { get; set; }
        [JsonProperty("modUserId")]
        public ulong ModUserId { get; set; }
        [JsonProperty("warningId")]
        public ulong WarningId { get; set; }
        [JsonProperty("warnReason")]
        public string WarnReason { get; set; }
        [JsonProperty("warnTimestamp")]
        public DateTime WarnTimestamp { get; set; }
        [JsonProperty("contextLink")]
        public string ContextLink { get; set; }

    }

    public struct ConfigJson
    {
        [JsonProperty("core")]
        public CoreConfig Core { get; private set; }

        [JsonProperty("redis")]
        public RedisConfig Redis { get; private set; }

        [JsonProperty("trialModRole")]
        public ulong TrialModRole { get; private set; }

        [JsonProperty("modRole")]
        public ulong ModRole { get; private set; }

        [JsonProperty("adminRole")]
        public ulong AdminRole { get; private set; }

        [JsonProperty("logChannel")]
        public ulong LogChannel { get; set; }

        [JsonProperty("serverID")]
        public ulong ServerID { get; set; }

    }

    public class CoreConfig
    {
        [JsonProperty("token")]
        public string Token { get; private set; }

        [JsonProperty("prefixes")]
        public List<string> Prefixes { get; private set; }
    }

    public class RedisConfig
    {
        [JsonProperty("host")]
        public string Host { get; private set; }

        [JsonProperty("port")]
        public ulong Port { get; private set; }
    }

}
