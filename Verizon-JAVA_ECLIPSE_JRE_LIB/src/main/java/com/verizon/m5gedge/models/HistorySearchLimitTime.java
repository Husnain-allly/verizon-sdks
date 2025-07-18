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
 * This is a model class for HistorySearchLimitTime type.
 */
public class HistorySearchLimitTime {
    private LocalDateTime startOn;
    private NumericalData duration;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public HistorySearchLimitTime() {
    }

    /**
     * Initialization constructor.
     * @param  startOn  LocalDateTime value for startOn.
     * @param  duration  NumericalData value for duration.
     */
    public HistorySearchLimitTime(
            LocalDateTime startOn,
            NumericalData duration) {
        this.startOn = startOn;
        this.duration = duration;
    }

    /**
     * Getter for StartOn.
     * The starting date-time for this request.
     * @return Returns the LocalDateTime
     */
    @JsonGetter("startOn")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    @JsonSerialize(using = DateTimeHelper.Rfc8601DateTimeSerializer.class)
    public LocalDateTime getStartOn() {
        return startOn;
    }

    /**
     * Setter for StartOn.
     * The starting date-time for this request.
     * @param startOn Value for LocalDateTime
     */
    @JsonSetter("startOn")
    @JsonDeserialize(using = DateTimeHelper.Rfc8601DateTimeDeserializer.class)
    public void setStartOn(LocalDateTime startOn) {
        this.startOn = startOn;
    }

    /**
     * Getter for Duration.
     * Describes value and unit of time.
     * @return Returns the NumericalData
     */
    @JsonGetter("duration")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public NumericalData getDuration() {
        return duration;
    }

    /**
     * Setter for Duration.
     * Describes value and unit of time.
     * @param duration Value for NumericalData
     */
    @JsonSetter("duration")
    public void setDuration(NumericalData duration) {
        this.duration = duration;
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
     * Converts this HistorySearchLimitTime into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "HistorySearchLimitTime [" + "startOn=" + startOn + ", duration=" + duration
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link HistorySearchLimitTime.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link HistorySearchLimitTime.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .startOn(getStartOn())
                .duration(getDuration());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link HistorySearchLimitTime}.
     */
    public static class Builder {
        private LocalDateTime startOn;
        private NumericalData duration;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for startOn.
         * @param  startOn  LocalDateTime value for startOn.
         * @return Builder
         */
        public Builder startOn(LocalDateTime startOn) {
            this.startOn = startOn;
            return this;
        }

        /**
         * Setter for duration.
         * @param  duration  NumericalData value for duration.
         * @return Builder
         */
        public Builder duration(NumericalData duration) {
            this.duration = duration;
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
         * Builds a new {@link HistorySearchLimitTime} object using the set fields.
         * @return {@link HistorySearchLimitTime}
         */
        public HistorySearchLimitTime build() {
            HistorySearchLimitTime model =
                    new HistorySearchLimitTime(startOn, duration);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
