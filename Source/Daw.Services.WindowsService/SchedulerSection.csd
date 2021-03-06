﻿<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="afb4b1eb-cb3b-4ee5-8038-6c72905ebbaa" namespace="Daw.Services.WindowsService" xmlSchemaNamespace="urn:Daw.Services.WindowsService" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationSection name="SchedulerSection" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="schedulerSection">
      <elementProperties>
        <elementProperty name="Schedules" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="schedules" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/afb4b1eb-cb3b-4ee5-8038-6c72905ebbaa/Schedules" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElementCollection name="Schedules" xmlItemName="scheduleItem" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <attributeProperties>
        <attributeProperty name="name" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/afb4b1eb-cb3b-4ee5-8038-6c72905ebbaa/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <itemType>
        <configurationElementMoniker name="/afb4b1eb-cb3b-4ee5-8038-6c72905ebbaa/ScheduleItem" />
      </itemType>
    </configurationElementCollection>
    <configurationElement name="ScheduleItem">
      <attributeProperties>
        <attributeProperty name="name" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/afb4b1eb-cb3b-4ee5-8038-6c72905ebbaa/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="url" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="url" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/afb4b1eb-cb3b-4ee5-8038-6c72905ebbaa/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="intervalsecs" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="intervalsecs" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/afb4b1eb-cb3b-4ee5-8038-6c72905ebbaa/Int32" />
          </type>
        </attributeProperty>
        <attributeProperty name="bookie" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="bookie" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/afb4b1eb-cb3b-4ee5-8038-6c72905ebbaa/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="sport" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="sport" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/afb4b1eb-cb3b-4ee5-8038-6c72905ebbaa/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>