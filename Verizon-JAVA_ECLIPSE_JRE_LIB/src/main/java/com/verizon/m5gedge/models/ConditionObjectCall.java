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
 * This is a model class for ConditionObjectCall type.
 */
public class ConditionObjectCall {
    private ConditionType conditionType;
    private Comparitor comparitor;
    private Integer threshold;
    private ThresholdUnit thresholdUnit;
    private RulesCycleType cycleType;
    private AllowanceThreshold allowanceThreshold;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public ConditionObjectCall() {
    }

    /**
     * Initialization constructor.
     * @param  conditionType  ConditionType value for conditionType.
     * @param  comparitor  Comparitor value for comparitor.
     * @param  threshold  Integer value for threshold.
     * @param  thresholdUnit  ThresholdUnit value for thresholdUnit.
     * @param  cycleType  RulesCycleType value for cycleType.
     * @param  allowanceThreshold  AllowanceThreshold value for allowanceThreshold.
     */
    public ConditionObjectCall(
            ConditionType conditionType,
            Comparitor comparitor,
            Integer threshold,
            ThresholdUnit thresholdUnit,
            RulesCycleType cycleType,
            AllowanceThreshold allowanceThreshold) {
        this.conditionType = conditionType;
        this.comparitor = comparitor;
        this.threshold = threshold;
        this.thresholdUnit = thresholdUnit;
        this.cycleType = cycleType;
        this.allowanceThreshold = allowanceThreshold;
    }

    /**
     * Getter for ConditionType.
     * The condition type being monitored
     * @return Returns the ConditionType
     */
    @JsonGetter("conditionType")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public ConditionType getConditionType() {
        return conditionType;
    }

    /**
     * Setter for ConditionType.
     * The condition type being monitored
     * @param conditionType Value for ConditionType
     */
    @JsonSetter("conditionType")
    public void setConditionType(ConditionType conditionType) {
        this.conditionType = conditionType;
    }

    /**
     * Getter for Comparitor.
     * The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To
     * @return Returns the Comparitor
     */
    @JsonGetter("comparitor")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Comparitor getComparitor() {
        return comparitor;
    }

    /**
     * Setter for Comparitor.
     * The boolean of the comparison. `gt` is Greater Than, `lt` is Less Than and `eq` is Equal To
     * @param comparitor Value for Comparitor
     */
    @JsonSetter("comparitor")
    public void setComparitor(Comparitor comparitor) {
        this.comparitor = comparitor;
    }

    /**
     * Getter for Threshold.
     * The threshold value the trigger monitors for
     * @return Returns the Integer
     */
    @JsonGetter("threshold")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Integer getThreshold() {
        return threshold;
    }

    /**
     * Setter for Threshold.
     * The threshold value the trigger monitors for
     * @param threshold Value for Integer
     */
    @JsonSetter("threshold")
    public void setThreshold(Integer threshold) {
        this.threshold = threshold;
    }

    /**
     * Getter for ThresholdUnit.
     * The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits
     * @return Returns the ThresholdUnit
     */
    @JsonGetter("thresholdUnit")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public ThresholdUnit getThresholdUnit() {
        return thresholdUnit;
    }

    /**
     * Setter for ThresholdUnit.
     * The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits
     * @param thresholdUnit Value for ThresholdUnit
     */
    @JsonSetter("thresholdUnit")
    public void setThresholdUnit(ThresholdUnit thresholdUnit) {
        this.thresholdUnit = thresholdUnit;
    }

    /**
     * Getter for CycleType.
     * The interval to monitor for the threshold. This can be Daily, Weekly or Monthly
     * @return Returns the RulesCycleType
     */
    @JsonGetter("cycleType")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public RulesCycleType getCycleType() {
        return cycleType;
    }

    /**
     * Setter for CycleType.
     * The interval to monitor for the threshold. This can be Daily, Weekly or Monthly
     * @param cycleType Value for RulesCycleType
     */
    @JsonSetter("cycleType")
    public void setCycleType(RulesCycleType cycleType) {
        this.cycleType = cycleType;
    }

    /**
     * Getter for AllowanceThreshold.
     * @return Returns the AllowanceThreshold
     */
    @JsonGetter("allowanceThreshold")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public AllowanceThreshold getAllowanceThreshold() {
        return allowanceThreshold;
    }

    /**
     * Setter for AllowanceThreshold.
     * @param allowanceThreshold Value for AllowanceThreshold
     */
    @JsonSetter("allowanceThreshold")
    public void setAllowanceThreshold(AllowanceThreshold allowanceThreshold) {
        this.allowanceThreshold = allowanceThreshold;
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
     * Converts this ConditionObjectCall into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "ConditionObjectCall [" + "conditionType=" + conditionType + ", comparitor="
                + comparitor + ", threshold=" + threshold + ", thresholdUnit=" + thresholdUnit
                + ", cycleType=" + cycleType + ", allowanceThreshold=" + allowanceThreshold
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link ConditionObjectCall.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link ConditionObjectCall.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .conditionType(getConditionType())
                .comparitor(getComparitor())
                .threshold(getThreshold())
                .thresholdUnit(getThresholdUnit())
                .cycleType(getCycleType())
                .allowanceThreshold(getAllowanceThreshold());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link ConditionObjectCall}.
     */
    public static class Builder {
        private ConditionType conditionType;
        private Comparitor comparitor;
        private Integer threshold;
        private ThresholdUnit thresholdUnit;
        private RulesCycleType cycleType;
        private AllowanceThreshold allowanceThreshold;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for conditionType.
         * @param  conditionType  ConditionType value for conditionType.
         * @return Builder
         */
        public Builder conditionType(ConditionType conditionType) {
            this.conditionType = conditionType;
            return this;
        }

        /**
         * Setter for comparitor.
         * @param  comparitor  Comparitor value for comparitor.
         * @return Builder
         */
        public Builder comparitor(Comparitor comparitor) {
            this.comparitor = comparitor;
            return this;
        }

        /**
         * Setter for threshold.
         * @param  threshold  Integer value for threshold.
         * @return Builder
         */
        public Builder threshold(Integer threshold) {
            this.threshold = threshold;
            return this;
        }

        /**
         * Setter for thresholdUnit.
         * @param  thresholdUnit  ThresholdUnit value for thresholdUnit.
         * @return Builder
         */
        public Builder thresholdUnit(ThresholdUnit thresholdUnit) {
            this.thresholdUnit = thresholdUnit;
            return this;
        }

        /**
         * Setter for cycleType.
         * @param  cycleType  RulesCycleType value for cycleType.
         * @return Builder
         */
        public Builder cycleType(RulesCycleType cycleType) {
            this.cycleType = cycleType;
            return this;
        }

        /**
         * Setter for allowanceThreshold.
         * @param  allowanceThreshold  AllowanceThreshold value for allowanceThreshold.
         * @return Builder
         */
        public Builder allowanceThreshold(AllowanceThreshold allowanceThreshold) {
            this.allowanceThreshold = allowanceThreshold;
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
         * Builds a new {@link ConditionObjectCall} object using the set fields.
         * @return {@link ConditionObjectCall}
         */
        public ConditionObjectCall build() {
            ConditionObjectCall model =
                    new ConditionObjectCall(conditionType, comparitor, threshold, thresholdUnit,
                            cycleType, allowanceThreshold);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
