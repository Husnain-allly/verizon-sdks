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
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.Map;

/**
 * This is a model class for Rbstiltconfig type.
 */
public class Rbstiltconfig {
    private RbsHighPrecisionTiltConfig rbsHighPrecisionTiltConfig;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public Rbstiltconfig() {
    }

    /**
     * Initialization constructor.
     * @param  rbsHighPrecisionTiltConfig  RbsHighPrecisionTiltConfig value for
     *         rbsHighPrecisionTiltConfig.
     */
    public Rbstiltconfig(
            RbsHighPrecisionTiltConfig rbsHighPrecisionTiltConfig) {
        this.rbsHighPrecisionTiltConfig = rbsHighPrecisionTiltConfig;
    }

    /**
     * Getter for RbsHighPrecisionTiltConfig.
     * @return Returns the RbsHighPrecisionTiltConfig
     */
    @JsonGetter("RbsHighPrecisionTiltConfig")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public RbsHighPrecisionTiltConfig getRbsHighPrecisionTiltConfig() {
        return rbsHighPrecisionTiltConfig;
    }

    /**
     * Setter for RbsHighPrecisionTiltConfig.
     * @param rbsHighPrecisionTiltConfig Value for RbsHighPrecisionTiltConfig
     */
    @JsonSetter("RbsHighPrecisionTiltConfig")
    public void setRbsHighPrecisionTiltConfig(RbsHighPrecisionTiltConfig rbsHighPrecisionTiltConfig) {
        this.rbsHighPrecisionTiltConfig = rbsHighPrecisionTiltConfig;
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
     * Converts this Rbstiltconfig into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Rbstiltconfig [" + "rbsHighPrecisionTiltConfig=" + rbsHighPrecisionTiltConfig
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link Rbstiltconfig.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Rbstiltconfig.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .rbsHighPrecisionTiltConfig(getRbsHighPrecisionTiltConfig());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link Rbstiltconfig}.
     */
    public static class Builder {
        private RbsHighPrecisionTiltConfig rbsHighPrecisionTiltConfig;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for rbsHighPrecisionTiltConfig.
         * @param  rbsHighPrecisionTiltConfig  RbsHighPrecisionTiltConfig value for
         *         rbsHighPrecisionTiltConfig.
         * @return Builder
         */
        public Builder rbsHighPrecisionTiltConfig(
                RbsHighPrecisionTiltConfig rbsHighPrecisionTiltConfig) {
            this.rbsHighPrecisionTiltConfig = rbsHighPrecisionTiltConfig;
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
         * Builds a new {@link Rbstiltconfig} object using the set fields.
         * @return {@link Rbstiltconfig}
         */
        public Rbstiltconfig build() {
            Rbstiltconfig model =
                    new Rbstiltconfig(rbsHighPrecisionTiltConfig);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
