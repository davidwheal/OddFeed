<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:msxsl="urn:schemas-microsoft-com:xslt"
                exclude-result-prefixes="msxsl Ext"
                xmlns:Ext="urn:OddsFeedXslExtensions">
  <xsl:output method="xml" indent="yes" encoding="utf-16" omit-xml-declaration="no" standalone="yes" />

  <xsl:template match="/" name="root">
    <oddfeed bookie="WilliamHill">
      <xsl:attribute name="generateddate">
        <xsl:value-of select="Ext:CurrentDate()" />
      </xsl:attribute>
      <xsl:attribute name="generatedtime">
        <xsl:value-of select="Ext:CurrentTime()" />
      </xsl:attribute>

      <xsl:attribute name="sport">
        <xsl:value-of select="Ext:GetSport()" />
      </xsl:attribute>

      <xsl:attribute name="feedname">
        <xsl:value-of select="Ext:GetFeedName()" />
      </xsl:attribute>

      <xsl:attribute name="feedtype">
        <xsl:value-of select="Ext:GetFeedType()" />
      </xsl:attribute>
      <xsl:apply-templates />

    </oddfeed>
  </xsl:template>

  <xsl:template match="oxip/response/williamhill/class/type" name="events">
    <event>
      <xsl:attribute name="name">
        <xsl:value-of select="Ext:DoEventSubstitutions('HorseRacing',@name)" />
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:value-of select="@id" />
      </xsl:attribute>
      <xsl:attribute name="date">
        <xsl:value-of select="Ext:ParseWilliamHillEventDate(concat(market/@date,market/@time))" />
      </xsl:attribute>
      <xsl:attribute name="meeting">
        <xsl:value-of select="@name" />
      </xsl:attribute>
      <xsl:attribute name="venue">
        <xsl:value-of select="@name" />
      </xsl:attribute>
      <xsl:attribute name="team1">
      </xsl:attribute>
      <xsl:attribute name="team2">
      </xsl:attribute>
      <xsl:apply-templates />
    </event>
  </xsl:template>

  <xsl:template match="market" name="market">
    <market>
      <xsl:attribute name="name">
        <xsl:value-of select="@name" />
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:value-of select="@id" />
      </xsl:attribute>
      <xsl:attribute name="start">
        <xsl:value-of select="Ext:ParseWilliamHillEventDate(concat(@date,@time))" />
      </xsl:attribute>
      <xsl:attribute name="inplay">
        <xsl:value-of select="Ext:GetFlag('false')" />
      </xsl:attribute>
      <xsl:attribute name="suspended">
        <xsl:value-of select="Ext:GetFlag('false')" />
      </xsl:attribute>
      <xsl:attribute name="ewplaces">
        <xsl:value-of select="@ewPlaces" />
      </xsl:attribute>
      <xsl:attribute name="ewreduction">
        <xsl:value-of select="@ewReduction" />
      </xsl:attribute>
      <xsl:apply-templates />
    </market>
  </xsl:template>

  <xsl:template match="participant" name="selection">
    <sel>
      <xsl:attribute name="name">
        <xsl:value-of select="@name" />
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:value-of select="@id" />
      </xsl:attribute>
      <xsl:apply-templates />
      <xsl:attribute name="price">
        <xsl:value-of select="@odds" />
      </xsl:attribute>
    </sel>
  </xsl:template>


</xsl:stylesheet>
