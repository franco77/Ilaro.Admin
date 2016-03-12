﻿using Ilaro.Admin.Extensions;
using Ilaro.Admin.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ilaro.Admin.Core
{
    public static class EntityExtensions
    {
        internal static  IEnumerable<Property> GetDefaultDisplayProperties(this Entity entity)
        {
            foreach (var property in entity.Properties)
            {
                // Get all properties which is not a key and foreign key
                if (!property.IsForeignKey)
                {
                    yield return property;
                }

                else if (property.IsForeignKey)
                {
                    // If is foreign key and not have reference property
                    if (
                        property.ReferenceProperty == null &&
                        !property.TypeInfo.IsCollection)
                    {
                        yield return property;
                    }
                    // If is foreign key and have foreign key, that means, 
                    // we have two properties for one database column, 
                    // so I want only that one who is a system type
                    else if (
                        property.ReferenceProperty != null &&
                        property.TypeInfo.IsSystemType &&
                        !property.TypeInfo.IsCollection)
                    {
                        yield return property;
                    }
                }
            }
        }

        internal static IEnumerable<Property> GetDefaultSearchProperties(this Entity entity)
        {
            return entity.Properties
                    .Where(x =>
                        !x.IsForeignKey &&
                        x.TypeInfo.IsAvailableForSearch);
        }

        internal static IEnumerable<Property> GetDefaultCreateProperties(
            this Entity entity,
            bool getKey = true,
            bool getForeignCollection = true)
        {
            foreach (var property in entity.Properties)
            {
                // Get all properties which is not a key and foreign key
                if (!property.IsKey && !property.IsForeignKey)
                {
                    yield return property;
                }
                // If property is key
                else if (
                    property.IsKey &&
                    property.IsAutoKey == false &&
                    getKey)
                {
                    yield return property;
                }
                else if (property.IsForeignKey)
                {
                    // If is foreign key and not have reference property
                    if (
                        property.ReferenceProperty == null &&
                        (getForeignCollection || !property.TypeInfo.IsCollection))
                    {
                        yield return property;
                    }
                    // If is foreign key and have foreign key, that means, 
                    // we have two properties for one database column, 
                    // so I want only that one who is a system type
                    else if (
                        property.ReferenceProperty != null &&
                        property.TypeInfo.IsSystemType &&
                        (getForeignCollection || !property.TypeInfo.IsCollection))
                    {
                        yield return property;
                    }
                }
            }
        }

        internal static void ClearPropertiesValues(this Entity entity)
        {
            foreach (var property in entity.Properties)
            {
                property.Value.Clear();
            }
        }

        internal static IList<GroupProperties> PrepareGroups(this Entity entity, IList<string> groupsNames)
        {
            var groupsDict = entity.GetDefaultCreateProperties()
                .GroupBy(x => x.GroupName)
                .ToDictionary(x => x.Key);

            var groups = new List<GroupProperties>();
            if (groupsNames.IsNullOrEmpty())
            {
                foreach (var group in groupsDict)
                {
                    groups.Add(new GroupProperties
                    {
                        GroupName = group.Key,
                        Properties = group.Value.ToList()
                    });
                }
            }
            else
            {
                foreach (var groupName in groupsNames)
                {
                    var trimedGroupName = groupName.TrimEnd('*');
                    if (!groupsDict.ContainsKey(trimedGroupName)) continue;

                    var group = groupsDict[trimedGroupName];

                    groups.Add(new GroupProperties
                    {
                        GroupName = @group.Key,
                        Properties = @group.ToList(),
                        IsCollapsed = groupName.EndsWith("*")
                    });
                }
            }

            return groups;
        }
    }
}