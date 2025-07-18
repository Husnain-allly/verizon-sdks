/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import com.fasterxml.jackson.databind.annotation.JsonDeserialize;
import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import com.verizon.m5gedge.DateTimeHelper;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.time.LocalDateTime;
import java.util.Map;

/**
 * This is a model class for UsageHistory type.
 */
public class UsageHistory {
    private Integer bytesUsed;
    private String serviceplan;
    private Integer smsUsed;
    private Integer moSms;
    private Integer mtSms;
    private String source;
    private LocalDateTime eventDateTime;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public UsageHistory() {
    }

    /**
     * Initialization constructor.
     * @param  bytesUsed  Integer value for bytesUsed.
     * @param  serviceplan  String value for serviceplan.
     * @param  smsUsed  Integer value for smsUsed.
     * @param  moSms  Integer value for moSms.
     * @param  mtSms  Integer value for mtSms.
     * @param  source  String value for source.
     * @param  eventDateTime  LocalDateTime value for eventDateTime.
     */
    public UsageHistory(
            Integer bytesUsed,
            String serviceplan,
            Integer smsUsed,
            Integer moSms,
            Integer mtSms,
            String source,
            LocalDateTime eventDateTime) {
        this.bytesUsed = bytesUsed;
        this.serviceplan = serviceplan;
        this.smsUsed = smsUsed;
        this.moSms = moSms;
        this.mtSms = mtSms;
        this.source = source;
        this.eventDateTime = eventDateTime;
    }

    /**
     * Getter for BytesUsed.
     * @return Returns the Integer
     */
    @JsonGetter("bytesUsed")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Integer getBytesUsed() {
        return bytesUsed;
    }

    /**
     * Setter for BytesUsed.
     * @param bytesUsed Value for Integer
     */
    @JsonSetter("bytesUsed")
    public void setBytesUsed(Integer bytesUsed) {
        this.bytesUsed = bytesUsed;
    }

    /**
     * Getter for Serviceplan.
     * @return Returns the String
     */
    @JsonGetter("serviceplan")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getServiceplan() {
        return serviceplan;
    }

    /**
     * Setter for Serviceplan.
     * @param serviceplan Value for String
     */
    @JsonSetter("serviceplan")
    public void setServiceplan(String serviceplan) {
        this.serviceplan = serviceplan;
    }

    /**
     * Getter for SmsUsed.
     * @return Returns the Integer
     */
    @JsonGetter("smsUsed")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Integer getSmsUsed() {
        return smsUsed;
    }

    /**
     * Setter for SmsUsed.
     * @param smsUsed Value for Integer
     */
    @JsonSetter("smsUsed")
    public void setSmsUsed(Integer smsUsed) {
        this.smsUsed = smsUsed;
    }

    /**
     * Getter for MoSms.
     * @return Returns the Integer
     */
    @JsonGetter("moSMS")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Integer getMoSms() {
        return moSms;
    }

    /**
     * Setter for MoSms.
     * @param moSms Value for Integer
     */
    @JsonSetter("moSMS")
    public void setMoSms(Integer moSms) {
        this.moSms = moSms;
    }

    /**
     * Getter for MtSms.
     * @return Returns the Integer
     */
    @JsonGetter("mtSMS")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Integer getMtSms() {
        return mtSms;
    }

    /**
     * Setter for MtSms.
     * @param mtSms Value for Integer
     */
    @JsonSetter("mtSMS")
    public void setMtSms(Integer mtSms) {
        this.mtSms = mtSms;
    }

    /**
     * Getter for Source.
     * @return Returns the String
     */
    @JsonGetter("source")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSource() {
        return source;
    }

    /**
     * Setter for Source.
     * @param source Value for String
     */
    @JsonSetter("source")
    public void setSource(String source) {
        this.source = source;
    }

    /**
     * Getter for EventDateTime.
     * @return Returns the LocalDateTime
     */
    @JsonGetter("eventDateTime")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    @JsonSerialize(using = DateTimeHelper.Rfc8601DateTimeSerializer.class)
    public LocalDateTime getEventDateTime() {
        return eventDateTime;
    }

    /**
     * Setter for EventDateTime.
     * @param eventDateTime Value for LocalDateTime
     */
    @JsonSetter("eventDateTime")
    @JsonDeserialize(using = DateTimeHelper.Rfc8601DateTimeDeserializer.class)
    public void setEventDateTime(LocalDateTime eventDateTime) {
        this.eventDateTime = eventDateTime;
    }

    /**
     * Hidden method for the serialization of additional properties.
     * @return The map of additionally set properties.
     */
    @JsonAnyGetter
    private Map<String, Object> getAdditionalProperties() {
        return additionalProperties.getAdditionalProperties();
    }

    /**
     * Hidden method for the de-serialization of additional properties.
     * @param name The name of the additional property.
     * @param value The Object value of the additional property.
     */
    @JsonAnySetter
    private void setAdditionalProperties(String name, Object value) {
        additionalProperties.setAdditionalProperty(name,
                ConversionHelper.convertToSimpleType(value,
                        x -> x),
                true);
    }

    /**
     * Getter for the value of additional properties based on provided property name.
     * @param name The name of the additional property.
     * @return Either the Object property value or null if not exist.
     */
    
    public Object getAdditionalProperty(String name) {
        return additionalProperties.getAdditionalProperty(name);
    }

    /**
     * Converts this UsageHistory into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "UsageHistory [" + "bytesUsed=" + bytesUsed + ", serviceplan=" + serviceplan
                + ", smsUsed=" + smsUsed + ", moSms=" + moSms + ", mtSms=" + mtSms + ", source="
                + source + ", eventDateTime=" + eventDateTime + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link UsageHistory.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link UsageHistory.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .bytesUsed(getBytesUsed())
                .serviceplan(getServiceplan())
                .smsUsed(getSmsUsed())
                .moSms(getMoSms())
                .mtSms(getMtSms())
                .source(getSource())
                .eventDateTime(getEventDateTime());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link UsageHistory}.
     */
    public static class Builder {
        private Integer bytesUsed;
        private String serviceplan;
        private Integer smsUsed;
        private Integer moSms;
        private Integer mtSms;
        private String source;
        private LocalDateTime eventDateTime;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for bytesUsed.
         * @param  bytesUsed  Integer value for bytesUsed.
         * @return Builder
         */
        public Builder bytesUsed(Integer bytesUsed) {
            this.bytesUsed = bytesUsed;
            return this;
        }

        /**
         * Setter for serviceplan.
         * @param  serviceplan  String value for serviceplan.
         * @return Builder
         */
        public Builder serviceplan(String serviceplan) {
            this.serviceplan = serviceplan;
            return this;
        }

        /**
         * Setter for smsUsed.
         * @param  smsUsed  Integer value for smsUsed.
         * @return Builder
         */
        public Builder smsUsed(Integer smsUsed) {
            this.smsUsed = smsUsed;
            return this;
        }

        /**
         * Setter for moSms.
         * @param  moSms  Integer value for moSms.
         * @return Builder
         */
        public Builder moSms(Integer moSms) {
            this.moSms = moSms;
            return this;
        }

        /**
         * Setter for mtSms.
         * @param  mtSms  Integer value for mtSms.
         * @return Builder
         */
        public Builder mtSms(Integer mtSms) {
            this.mtSms = mtSms;
            return this;
        }

        /**
         * Setter for source.
         * @param  source  String value for source.
         * @return Builder
         */
        public Builder source(String source) {
            this.source = source;
            return this;
        }

        /**
         * Setter for eventDateTime.
         * @param  eventDateTime  LocalDateTime value for eventDateTime.
         * @return Builder
         */
        public Builder eventDateTime(LocalDateTime eventDateTime) {
            this.eventDateTime = eventDateTime;
            return this;
        }

        /**
         * Setter for additional property that are not in model fields.
         * @param name The name of the additional property.
         * @param value The Object value of the additional property.
         * @return Builder.
         */
        public Builder additionalProperty(String name, Object value) {
            this.additionalProperties.setAdditionalProperty(name, value);
            return this;
        }

        /**
         * Builds a new {@link UsageHistory} object using the set fields.
         * @return {@link UsageHistory}
         */
        public UsageHistory build() {
            UsageHistory model =
                    new UsageHistory(bytesUsed, serviceplan, smsUsed, moSms, mtSms, source,
                            eventDateTime);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
