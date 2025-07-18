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
 * This is a model class for AccountLevelFilter type.
 */
public class AccountLevelFilter {
    private String separateOrCombined;
    private Accountnames accountNames;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public AccountLevelFilter() {
    }

    /**
     * Initialization constructor.
     * @param  separateOrCombined  String value for separateOrCombined.
     * @param  accountNames  Accountnames value for accountNames.
     */
    public AccountLevelFilter(
            String separateOrCombined,
            Accountnames accountNames) {
        this.separateOrCombined = separateOrCombined;
        this.accountNames = accountNames;
    }

    /**
     * Getter for SeparateOrCombined.
     * Determines whether or not to aggregate usage of multiple accounts together, or separate by
     * account. If this is null or not present, then the trigger will be for an individual line.
     * @return Returns the String
     */
    @JsonGetter("separateOrCombined")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSeparateOrCombined() {
        return separateOrCombined;
    }

    /**
     * Setter for SeparateOrCombined.
     * Determines whether or not to aggregate usage of multiple accounts together, or separate by
     * account. If this is null or not present, then the trigger will be for an individual line.
     * @param separateOrCombined Value for String
     */
    @JsonSetter("separateOrCombined")
    public void setSeparateOrCombined(String separateOrCombined) {
        this.separateOrCombined = separateOrCombined;
    }

    /**
     * Getter for AccountNames.
     * @return Returns the Accountnames
     */
    @JsonGetter("accountNames")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Accountnames getAccountNames() {
        return accountNames;
    }

    /**
     * Setter for AccountNames.
     * @param accountNames Value for Accountnames
     */
    @JsonSetter("accountNames")
    public void setAccountNames(Accountnames accountNames) {
        this.accountNames = accountNames;
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
     * Converts this AccountLevelFilter into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "AccountLevelFilter [" + "separateOrCombined=" + separateOrCombined
                + ", accountNames=" + accountNames + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link AccountLevelFilter.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link AccountLevelFilter.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .separateOrCombined(getSeparateOrCombined())
                .accountNames(getAccountNames());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link AccountLevelFilter}.
     */
    public static class Builder {
        private String separateOrCombined;
        private Accountnames accountNames;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for separateOrCombined.
         * @param  separateOrCombined  String value for separateOrCombined.
         * @return Builder
         */
        public Builder separateOrCombined(String separateOrCombined) {
            this.separateOrCombined = separateOrCombined;
            return this;
        }

        /**
         * Setter for accountNames.
         * @param  accountNames  Accountnames value for accountNames.
         * @return Builder
         */
        public Builder accountNames(Accountnames accountNames) {
            this.accountNames = accountNames;
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
         * Builds a new {@link AccountLevelFilter} object using the set fields.
         * @return {@link AccountLevelFilter}
         */
        public AccountLevelFilter build() {
            AccountLevelFilter model =
                    new AccountLevelFilter(separateOrCombined, accountNames);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
