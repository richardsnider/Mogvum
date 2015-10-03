﻿using System;
using System.Collections.Generic;
using Assets.Scripts.Enumerables;
using UnityEngine;

namespace Assets.Scripts.Characters
{
    [Serializable]
    public class CharacterType
    {
        ICollection<PrimaryType> PrimaryTypes;
        ICollection<SubType> SubTypes;

        public CharacterType(ICollection<PrimaryType> primaryTypes = null, ICollection<SubType> subTypes = null)
        {
            PrimaryTypes = primaryTypes ?? new List<PrimaryType>();
            SubTypes = subTypes ?? new List<SubType>();
        }

        public ICollection<PrimaryType> GetPrimaryTypes()
        {
            return PrimaryTypes;
        }

        public ICollection<SubType> GetSubTypes()
        {
            return SubTypes;
        }

        public void AddPrimaryType(PrimaryType type)
        {
            if (PrimaryTypes.Contains(type)) {
                Debug.LogError("Character's PrimaryTypes already contains " + Enum.GetName(typeof(PrimaryType), type) + ", so it cannot be added.");
                return;
            }
            //else if (Enum.IsDefined(typeof(PrimaryType), type)) {
            //    Debug.LogError("PrimaryType enum doesn't have a value for " + type + ", so it cannot be added.");
            //    return;
            //}

            PrimaryTypes.Add(type);
        }

        public void AddSubType(SubType type)
        {
            if (SubTypes.Contains(type))
            {
                Debug.LogError("Character's SubTypes already contains " + Enum.GetName(typeof(SubType), type) + ", so it cannot be added.");
                return;
            }
            //else if (Enum.IsDefined(typeof(SubType), type))
            //{
            //    Debug.LogError("SubType enum doesn't have a value for " + type + ", so it cannot be added.");
            //    return;
            //}

            SubTypes.Add(type);
        }

        public void RemovePrimaryType(PrimaryType type)
        {
            if (PrimaryTypes.Contains(type)) {
                PrimaryTypes.Remove(type);
            }
            else {
                Debug.LogError("Character's PrimaryTypes does not contain " + Enum.GetName(typeof(PrimaryType), type) + ", so it cannot be removed");
            }
        }

        public void RemoveSubType(SubType type)
        {
            if (SubTypes.Contains(type))
            {
                SubTypes.Remove(type);
            }
            else
            {
                Debug.LogError("Character's SubTypes does not contain " + Enum.GetName(typeof(SubType), type) + ", so it cannot be removed");
            }
        }


    }
}