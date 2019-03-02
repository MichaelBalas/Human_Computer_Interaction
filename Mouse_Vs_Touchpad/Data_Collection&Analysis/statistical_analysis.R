###
# A Comparative Evaluation Between Computer Mouse and Touchpad Usability in the Modern World
# Michael Balas 
####

generateTable = function(condition1, condition2) {
  table_comparison = as.data.frame(matrix(nrow=5, ncol=ncol(condition1)))
  row.names(table_comparison) = c("condition1_Means", "condition1_STD", "condition2_Means", "condition2_STD", "t-test_p")
  for (i in 1:ncol(condition1)) {
    colnames(table_comparison)[i] = colnames(condition1)[i]
    table_comparison[1,i] = mean(condition1[,i])
    table_comparison[2,i] = sd(condition1[,i])
    table_comparison[3,i] = mean(condition2[,i])
    table_comparison[4,i] = sd(condition2[,i])
    table_comparison[5,i] = t.test(condition1[,i], condition2[,i], paired=TRUE)$p.value
    print(t.test(condition1[,i], condition2[,i], paired=TRUE))
  }
  return(table_comparison)
}

##### Comparing Mouse-to-Touchpad tasks #####
# Load Data
mouse_MT_task = read.csv('Mouse/MT_Task.csv', header=TRUE, row.names=1, sep=',')
mouse_ERR_task = read.csv('Mouse/ERR_Task.csv', header=TRUE, row.names=1, sep=',')
pad_MT_task = read.csv('Touchpad/MT_Task.csv', header=TRUE, row.names=1, sep=',')
pad_ERR_task = read.csv('Touchpad/ERR_Task.csv', header=TRUE, row.names=1, sep=',')
# Compare Movement Time (MT)
MT_task = generateTable(mouse_MT_task, pad_MT_task)
format(MT_task, scientific=FALSE)
# Compare Error Count (ERR)
ERR_task = generateTable(mouse_ERR_task, pad_ERR_task)
format(ERR_task, scientific=FALSE)
#############################################


##### Comparing Mouse-to-Touchpad Overall Trial #####
# Load Data
mouse_MT_trial = read.csv('Mouse/MT_Trial.csv', header=TRUE, row.names=1, sep=',')
mouse_ERR_trial = read.csv('Mouse/ERR_Trial.csv', header=TRUE, row.names=1, sep=',')
pad_MT_trial = read.csv('Touchpad/MT_Trial.csv', header=TRUE, row.names=1, sep=',')
pad_ERR_trial = read.csv('Touchpad/ERR_Trial.csv', header=TRUE, row.names=1, sep=',')
# Compare Movement Time (MT)
MT_trial = generateTable(mouse_MT_trial, pad_MT_trial)
format(MT_trial, scientific=FALSE)
# Compare Error Count (ERR)
ERR_trial = generateTable(mouse_ERR_trial, pad_ERR_trial)
format(ERR_trial, scientific=FALSE)
# Compare total MT
total_MT_comparison = t.test(rowSums(mouse_MT_trial), rowSums(pad_MT_trial), paired=TRUE)
format(total_MT_comparison, scientific=FALSE)
# Compare total ERR
total_ERR_comparison = t.test(rowSums(mouse_ERR_trial), rowSums(pad_ERR_trial), paired=TRUE)
format(total_ERR_comparison, scientific=FALSE)
#####################################################

##### Evaluating Mouse Fatigue #####
mouse_MT_fatigue = generateTable(mouse_MT_task, mouse_MT_trial)
format(mouse_MT_fatigue, scientific=FALSE)
write.csv(mouse_MT_fatigue, 'mouse_MT_fatigue.csv', sep=',')
mouse_ERR_fatigue = generateTable(mouse_ERR_task, mouse_ERR_trial)
format(mouse_ERR_fatigue, scientific=FALSE)
write.csv(mouse_ERR_fatigue, 'mouse_ERR_fatigue.csv', sep=',')
####################################


##### Evaluating Touchpad Fatigue #####
pad_MT_fatigue = generateTable(pad_MT_task, pad_MT_trial)
format(pad_MT_fatigue, scientific=FALSE)
write.csv(pad_MT_fatigue, 'pad_MT_fatigue.csv', sep=',')
pad_ERR_fatigue = generateTable(pad_ERR_task, pad_ERR_trial)
format(pad_ERR_fatigue, scientific=FALSE)
write.csv(pad_ERR_fatigue, 'pad_ERR_fatigue.csv', sep=',')
#######################################


##### Comparing Mouse-to-Touchpad Fatigue? #####
# MT
delta_pad_MT = pad_MT_trial - pad_MT_task
delta_mouse_MT = mouse_MT_trial - mouse_MT_task
mouse_pad_MT_fatigue = generateTable(delta_mouse_MT, delta_pad_MT)
format(mouse_pad_MT_fatigue, scientific=FALSE)
# ERR
delta_pad_ERR = pad_ERR_trial - pad_ERR_task
delta_mouse_ERR = mouse_ERR_trial - mouse_ERR_task
mouse_pad_ERR_fatigue = generateTable(delta_mouse_ERR, delta_pad_ERR)
format(mouse_pad_ERR_fatigue, scientific=FALSE)
################################################


##### Comparing Mouse-to-Touchpad Gesture Control #####
mouse_gestures = read.csv('Mouse/mouse_gesture.csv', header=TRUE, row.names=1, sep=',')
touchpad_gestures = read.csv('Touchpad/touchpad_gesture.csv', header=TRUE, row.names=1, sep=',')
gesture_MT = generateTable(mouse_gestures, touchpad_gestures)
format(gesture_MT, scientific=FALSE)
# No errors for either device
################################################


##### Comparing Mouse-to-Touchpad Questionnaire #####
mouse_questionnaire = read.csv('Mouse/questionnaire.csv', header=TRUE, row.names=1, sep=',')
touchpad_questionnaire = read.csv('Touchpad/questionnaire.csv', header=TRUE, row.names=1, sep=',')
questionnaire_results = generateTable(mouse_questionnaire, touchpad_questionnaire)
format(questionnaire_results, scientific=FALSE)
#####################################################

generateTable2 = function(preferences) {
  table_comparison = as.data.frame(matrix(nrow=3, ncol=ncol(preferences)))
  row.names(table_comparison) = c("M_Frequency", "T_Frequency", "chi-test_p")
  for (i in 1:ncol(preferences)) {
    colnames(table_comparison)[i] = colnames(preferences)[i]
    numMouse = sum(preferences[,i] == "M")
    numPad = sum(preferences[,i] == "T")
    table_comparison[1,i] = numMouse
    table_comparison[2,i] = numPad
    table_comparison[3,i] = chisq.test(c(numMouse, numPad))$p.value
  }
  return(table_comparison)
}

##### Comparing Mouse-to-Touchpad Preference #####
preferences_table = read.csv('preferences.csv', header=TRUE, row.names=1, sep=',')
preference_results = generateTable2(preferences_table)
format(preference_results, scientific=FALSE)
##################################################



