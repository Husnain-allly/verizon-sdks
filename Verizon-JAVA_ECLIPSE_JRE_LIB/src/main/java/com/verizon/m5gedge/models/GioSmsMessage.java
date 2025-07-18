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
import java.util.List;
import java.util.Map;

/**
 * This is a model class for GioSmsMessage type.
 */
public class GioSmsMessage {
    private List<GioDeviceId> deviceIds;
    private String message;
    private LocalDateTime timestamp;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public GioSmsMessage() {
    }

    /**
     * Initialization constructor.
     * @param  deviceIds  List of GioDeviceId value for deviceIds.
     * @param  message  String value for message.
     * @param  timestamp  LocalDateTime value for timestamp.
     */
    public GioSmsMessage(
            List<GioDeviceId> deviceIds,
            String message,
            LocalDateTime timestamp) {
        this.deviceIds = deviceIds;
        this.message = message;
        this.timestamp = timestamp;
    }

    /**
     * Getter for DeviceIds.
     * @return Returns the List of GioDeviceId
     */
    @JsonGetter("deviceIds")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<GioDeviceId> getDeviceIds() {
        return deviceIds;
    }

    /**
     * Setter for DeviceIds.
     * @param deviceIds Value for List of GioDeviceId
     */
    @JsonSetter("deviceIds")
    public void setDeviceIds(List<GioDeviceId> deviceIds) {
        this.deviceIds = deviceIds;
    }

    /**
     * Getter for Message.
     * @return Returns the String
     */
    @JsonGetter("message")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getMessage() {
        return message;
    }

    /**
     * Setter for Message.
     * @param message Value for String
     */
    @JsonSetter("message")
    public void setMessage(String message) {
        this.message = message;
    }

    /**
     * Getter for Timestamp.
     * @return Returns the LocalDateTime
     */
    @JsonGetter("timestamp")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    @JsonSerialize(using = DateTimeHelper.Rfc8601DateTimeSerializer.class)
    public LocalDateTime getTimestamp() {
        return timestamp;
    }

    /**
     * Setter for Timestamp.
     * @param timestamp Value for LocalDateTime
     */
    @JsonSetter("timestamp")
    @JsonDeserialize(using = DateTimeHelper.Rfc8601DateTimeDeserializer.class)
    public void setTimestamp(LocalDateTime timestamp) {
        this.timestamp = timestamp;
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
     * Converts this GioSmsMessage into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "GioSmsMessage [" + "deviceIds=" + deviceIds + ", message=" + message
                + ", timestamp=" + timestamp + ", additionalProperties=" + additionalProperties
                + "]";
    }

    /**
     * Builds a new {@link GioSmsMessage.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link GioSmsMessage.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .deviceIds(getDeviceIds())
                .message(getMessage())
                .timestamp(getTimestamp());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link GioSmsMessage}.
     */
    public static class Builder {
        private List<GioDeviceId> deviceIds;
        private String message;
        private LocalDateTime timestamp;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for deviceIds.
         * @param  deviceIds  List of GioDeviceId value for deviceIds.
         * @return Builder
         */
        public Builder deviceIds(List<GioDeviceId> deviceIds) {
            this.deviceIds = deviceIds;
            return this;
        }

        /**
         * Setter for message.
         * @param  message  String value for message.
         * @return Builder
         */
        public Builder message(String message) {
            this.message = message;
            return this;
        }

        /**
         * Setter for timestamp.
         * @param  timestamp  LocalDateTime value for timestamp.
         * @return Builder
         */
        public Builder timestamp(LocalDateTime timestamp) {
            this.timestamp = timestamp;
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
         * Builds a new {@link GioSmsMessage} object using the set fields.
         * @return {@link GioSmsMessage}
         */
        public GioSmsMessage build() {
            GioSmsMessage model =
                    new GioSmsMessage(deviceIds, message, timestamp);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
