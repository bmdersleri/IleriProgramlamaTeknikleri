namespace App\Form;

use App\Painting\Color;
use Symfony\Component\Form\AbstractType;
use Symfony\Component\Form\DataMapperInterface;
use Symfony\Component\Form\Exception\UnexpectedTypeException;
use Symfony\Component\Form\FormInterface;

final class ColorType extends AbstractType implements DataMapperInterface
{
    // ...

    /**
     * @param Color|null $viewData
     */
    public function mapDataToForms($viewData, \Traversable $forms): void
    {
        // there is no data yet, so nothing to prepopulate
        if (null === $viewData) {
            return;
        }

        // invalid data type
        if (!$viewData instanceof Color) {
            throw new UnexpectedTypeException($viewData, Color::class);
        }

        /** @var FormInterface[] $forms */
        $forms = iterator_to_array($forms);

        // initialize form field values
        $forms['red']->setData($viewData->getRed());
        $forms['green']->setData($viewData->getGreen());
        $forms['blue']->setData($viewData->getBlue());
    }

    public function mapFormsToData(\Traversable $forms, &$viewData): void
    {
        /** @var FormInterface[] $forms */
        $forms = iterator_to_array($forms);

        // as data is passed by reference, overriding it will change it in
        // the form object as well
        // beware of type inconsistency, see caution below
        $viewData = new Color(
            $forms['red']->getData(),
            $forms['green']->getData(),
            $forms['blue']->getData()
        );
    }
}
