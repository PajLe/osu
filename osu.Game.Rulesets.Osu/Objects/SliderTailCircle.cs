// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Rulesets.Osu.Judgements;

namespace osu.Game.Rulesets.Osu.Objects
{
    public class SliderTailCircle : SliderCircle
    {
        public SliderTailCircle(Slider slider)
            : base(slider)
        {
        }

        protected override OsuJudgement CreateJudgement() => new OsuSliderTailJudgement();
    }
}
