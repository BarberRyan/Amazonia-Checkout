using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ValidationMachine
{
    public class VM_Factory
    {
        public Dictionary<Control, VMachine> VMachines = new Dictionary<Control, VMachine>();
        
        /// <summary>
        /// Adds empty machine to avoid null object issues
        /// </summary>
        /// <param name="target">control to target</param>
        private void AddMachine(Control target)
        {
            VMachine newMachine = new VMachine(target);

            VMachines.Add(target, newMachine);
        }

        /// <summary>
        /// Adds a validator to the machine
        /// </summary>
        /// <param name="target">control to target</param>
        /// <param name="validator">Type of validation required</param>
        /// <param name="args">Optional arguments (see VMachine for parameter requirements)</param>
        public void AddValidator(Control target, VM_Type validator, params Object[] args)
        {
            if(VMachines == null)
            {
                VMachines = new Dictionary<Control, VMachine>();
            }
            if (VMachines.ContainsKey(target))
            {
                VMachines[target].Add(validator, args);
            }
            else
            {
                AddMachine(target);
                AddValidator(target, validator, args);
            }
        }

        /// <summary>
        /// Creates a feedback event triggered by validation
        /// </summary>
        /// <param name="target">control to target</param>
        /// <param name="status">status that triggers the event</param>
        /// <param name="feedback">method name or lambda expression to trigger</param>
        /// <param name="feedbackCase">set to false to trigger event when status is not present</param>
        public void AddFeedback(Control target, VM_Status status, Action feedback, bool feedbackCase = true)
        {
            if (VMachines.ContainsKey(target))
            {
                VMachines[target].AddFeedback(status, feedback, feedbackCase);
            }
        }

        /// <summary>
        /// Validates all validators
        /// </summary>
        /// <param name="feedback">should feedback actions trigger?</param>
        /// <returns>List of tuples containing the control and appropriate statuses</returns>
        public List<(Control, List<VM_Status>)> ValidateAll(bool feedback = true)
        {
            List<(Control, List<VM_Status>)> output = new List<(Control, List<VM_Status>)>();

            foreach(Control control in VMachines.Keys)
            {
                List<VM_Status> statuses = new List<VM_Status>();
                if (feedback)
                {
                    statuses = VMachines[control].Feedback();
                }
                else
                {
                    statuses = VMachines[control].Validate();
                }
                output.Add((control, statuses));
            }
            return output;
        }


        /// <summary>
        /// Validates only one control
        /// </summary>
        /// <param name="control">Control to validate</param>
        /// <param name="feedback">Boolean representing whether or not to activate feedback</param>
        /// <returns>List of tuples containing the control and appropriate statuses</returns>
        public List<(Control, List<VM_Status>)> Validate(Control control, bool feedback = true)
        {
            List<(Control, List<VM_Status>)> output = new List<(Control, List<VM_Status>)>();
            List<VM_Status> statuses = new List<VM_Status>();
            
            if (feedback)
            {
                statuses = VMachines[control].Feedback();
            }
            else
            {
                statuses = VMachines[control].Validate();
            }

            output.Add((control, statuses));
            
            return output;
        }
    }
}
