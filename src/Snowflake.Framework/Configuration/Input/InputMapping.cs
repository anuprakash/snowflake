﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Snowflake.Configuration.Input;
using Snowflake.Input.Controller;
using Snowflake.Input.Device;
using Snowflake.JsonConverters;

namespace Snowflake.Configuration.Input
{
    [JsonConverter(typeof(InputMappingConverter))]
    public class InputMapping : IInputMapping
    {
        private readonly IDictionary<ControllerElement, string> elementMappings;
        private readonly string nullMapping;

        public string this[ControllerElement element] => this.elementMappings.ContainsKey(element) ? this.elementMappings[element] : this.nullMapping;

        public InputApi InputApi { get; }
        public IEnumerable<string> DeviceLayouts { get; }


        public InputMapping(IDictionary<ControllerElement, string> elementMappings, string nullMapping, InputApi inputApi, IEnumerable<string> deviceLayouts)
        {
            this.elementMappings = elementMappings;
            this.nullMapping = nullMapping;
            this.InputApi = inputApi;
            this.DeviceLayouts = deviceLayouts;
        }
    }
}
